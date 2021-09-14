using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UddataH1.Models
{
    class Teacher : Person
    {
        public List<Course> courses = new List<Course>();
    }
}
