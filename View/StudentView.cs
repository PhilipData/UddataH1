using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UddataH1.Models;

namespace UddataH1.View
{
    class StudentView
    {
        public List<Student> ListOfAllStudents = new List<Student>();

        void InsertData()
        {
            ListOfAllStudents.Add(new Student()
            {
                Id = 1,
                Name = "Andersen",
                Email = "Andersen@gmail.com"

            });
            ListOfAllStudents.Add(new Student()
            {
                Id = 2,
                Name = "Henning",
                Email = "h@gmail.com"

            });
        }

        public StudentView()
        {
            InsertData();
        }

        public void AddStudent()
        {
            Student student = new Student();
            Console.WriteLine("Insert Name on Student: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("Insert Email on Student: ");
            student.Email = Console.ReadLine();

            ListOfAllStudents.Add(student);
            ShowStudent(student);
        }


        public void SearchTeacher()
        {
            Console.WriteLine("Search By Name:");
            //Viser listen vi modtager fra søgning, som er specificeret af vores input 
            ShowStudents(SearchStudentsByName(Console.ReadLine()));
        }

        public List<Student> SearchStudentsByName(string search)
        {
            List<Student> searchResultList = new List<Student>();
            foreach (Student student in ListOfAllStudents)
            {
                if (student.Name.Contains(search))
                    searchResultList.Add(student);
                else if (student.Email.Contains(search))
                    searchResultList.Add(student);
            }
            return searchResultList;
        }

        public void ShowStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                ShowStudent(student);
            }
        }

        public void ShowStudent(Student student)
        {
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Email: " + student.Email);
        }

        public void StudentWarning()
        {

        }

    }
}
