using UddataH1.Models;
using UddataH1.View;
using System;
using System.Collections.Generic;

namespace UddataH1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Menu MainMenu = new Menu();
            MainMenu.MainMenu();
        }
        void InsertData()
        {
            Teacher teacher1 = new Teacher()
            {
                Id = 1,
                Name = "Andersen",
                Email = "Andersen@gmail.com"

            };
            Course Math = new Course()
            {
                Id= 1,
                Name = "Mathmatics",
                Teacher = teacher1
            };
            
            Student student1 = new Student()
            {
                Id = 1,
                Name = "John",
                Email = "JohnnyGood@gmail.com",
                CourseList = new List<Course>()
                {
                    Math
                }
            };
            teacher1.courses.Add(Math);
            
        }
    }
}
