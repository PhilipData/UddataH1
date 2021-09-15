using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UddataH1.Models;

namespace UddataH1.View
{
    class TeacherView
    {
        public List<Teacher> ListOfAllTeachers = new List<Teacher>();

        void InsertData()
        {
            ListOfAllTeachers.Add(new Teacher()
            {
                Id = 1,
                Name = "Andersen",
                Email = "Andersen@gmail.com"

            });
            ListOfAllTeachers.Add(new Teacher()
            {
                Id = 2,
                Name = "Henning",
                Email = "h@gmail.com"

            });
        }

        public TeacherView()
        {
            InsertData();
        }

        public void AddTeacher()
        {
            Teacher teacher = new Teacher();
            Console.WriteLine("Insert Name on Teacher: ");
            teacher.Name = Console.ReadLine();

            Console.WriteLine("Insert Email on Teacher: ");
            teacher.Email = Console.ReadLine();

            bool isSyntaxOk = false;
            do isSyntaxOk = IsCoffeeClub(teacher, isSyntaxOk);
            while (!isSyntaxOk);
            ListOfAllTeachers.Add(teacher);
            ShowTeacher(teacher);
        }


        public void SearchTeacher()
        {
            Console.WriteLine("Search By Name:");
            //Viser listen vi modtager fra søgning, som er specificeret af vores input 
            ShowTeachers(SearchTeacherByName(Console.ReadLine()));
        }

        public List<Teacher> SearchTeacherByName(string search)
        {
            List<Teacher> searchResultList = new List<Teacher>();
            foreach (Teacher teacher in ListOfAllTeachers)
            {
                if (teacher.Name.Contains(search))
                    searchResultList.Add(teacher);
                else if (teacher.Email.Contains(search))
                    searchResultList.Add(teacher);
            }
                return searchResultList;
        }

        public void ShowTeachers(List<Teacher> teachers)
        {
            foreach (Teacher teacher in teachers)
            {
                ShowTeacher(teacher);
            }
        }

        public void ShowTeacher(Teacher teacher)
        {
            Console.WriteLine("Name: " + teacher.Name);
            Console.WriteLine("Email: " + teacher.Email);
        }

        private static bool IsCoffeeClub(Teacher teacher, bool isSyntaxOk)
        {
            Console.WriteLine("Is the teacher signed up to the Coffee club? Tast\n 1: (j/n)");
            string s = Console.ReadLine().ToLower();
            if (s == "j" || s == "ja" || s == "y" || s == "yes")
            {
                teacher.CoffeClub = true;
                isSyntaxOk = true;
            }
            else if (s == "n" || s == "nej" || s == "no")
            {
                teacher.CoffeClub = false;
                isSyntaxOk = true;
            }

            return isSyntaxOk;
        }
    }
}
