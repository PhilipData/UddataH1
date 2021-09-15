using System;
using UddataH1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace UddataH1.View
{
    class Menu
    {
        TeacherView tv = new TeacherView();
        public void MainMenu()
        {
            while (true)
            {
                Console.WriteLine("*** MAIN MENU ***");

                Console.WriteLine("1: Show all teachers");
                Console.WriteLine("2: Add Teacher");
                Console.WriteLine("3: Add Teacher");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        tv.ShowTeachers(tv.ListOfAllTeachers);
                        break;
                    case "2":
                        // Add new teacher
                        tv.AddTeacher();
                        break;
                    case "3":
                        tv.SearchTeacher();
                        // show All Students
                        break;
                    case "4":
                        // Add new Student
                        break;
                    case "5":
                        //Search Teacher
                        break;
                    case "6":
                        //Search Student
                        break;
                    default:

                        break;
                }
            }
            

        }

        
    }
}
