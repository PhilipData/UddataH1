using System;
using UddataH1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UddataH1.View
{
    class Menu
    {
        public void MainMenu()
        {
            Console.WriteLine("*** MAIN MENU ***");

            Console.WriteLine("1: Show all teachers");
            Console.WriteLine("2: Add Teacher");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":

                    break;
                case "2":
                    AddTeacher();
                    break;
                case "3":

                    break;
                case "4":

                    break;
                case "5":

                    break;
                default:

                    break;
            }

        }

        private void AddTeacher()
        {
            Teacher teacher = new Teacher();
            Console.WriteLine("Insert Name on Teacher: ");
            teacher.Name = Console.ReadLine();

            Console.WriteLine("Insert Email on Teacher: ");
            teacher.Email = Console.ReadLine();

            Console.WriteLine("Is the teacher signed up to the Coffee club? Tast\n 1: Yes\n2:No");

            teacher.CoffeClub = true;
        }
        static internal bool YESNO(string YESNO)
        {
            
            if (YESNO.ToUpper() == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        
    }
}
