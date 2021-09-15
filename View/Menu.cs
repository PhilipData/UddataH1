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
                MenuText();
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        // Add new teacher
                        tv.AddTeacher();
                        break;
                    case "2":
                        // show All Teachers
                        tv.ShowTeachers(tv.ListOfAllTeachers);
                        break;
                    case "3":
                        //Search for teacher by Name (eller var det søg efter navne der indeholder hvad end var indtastet)
                        tv.SearchTeacher();
                        break;
                    case "4":
                        // Add new Student
                        break;
                    case "5":
                        //Show all students
                        break;
                    case "6":
                        //Search for Student by Name(probably the same as teach above searching for what ever that have been typed
                        //in a looks the list over anything that has the characters in the field
                        break;
                    case "7":
                        //All Courses
                        break;
                    case "8":
                        //Exit
                        break;
                    default:

                        break;
                }
            }


        }

        private static void MenuText()
        {
            Console.WriteLine("*** MAIN MENU ***");
            Console.WriteLine("1: Add Teacher");
            Console.WriteLine("2: Show all Teachers");
            Console.WriteLine("3: Search For Teacher By Name");
            Console.WriteLine("4: Add Student");
            Console.WriteLine("5: Show All Students");
            Console.WriteLine("6: Search For Student By Name");
            Console.WriteLine("7: All courses");
            Console.WriteLine("8: Exit");
        }

    }
}
