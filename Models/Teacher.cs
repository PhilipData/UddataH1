using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UddataH1.Models
{
    sealed class Teacher : Person //sealed makes it so the class can't be inherited from.
    {
        public List<Course> courses = new List<Course>();
        public bool CoffeClub { get; set; }
    }
}
