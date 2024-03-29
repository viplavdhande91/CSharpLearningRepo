using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Student
    {
        public int StudentID { get; set; }
        public String? StudentName { get; set; }
        public int Age { get; set; }

        public int? StandardID { get; set; } = 0; 
    }

    public class Standard{  
        public int StandardID { get; set; }
        public string StandardName { get; set; }
    }


}
