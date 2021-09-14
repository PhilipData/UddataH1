using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UddataH1.Models
{
    class Student : Person
    {
        
        public List<Course> CourseList { get; set; }
    }
}
