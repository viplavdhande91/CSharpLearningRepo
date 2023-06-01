using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class DestructorDemo
    {
        //constructor
        public DestructorDemo()
        {
            //file & db connection logic here
            Console.WriteLine("File is opened");
        }

        //destructor
        ~DestructorDemo()
        {
            //file & db closing logic here
            Console.WriteLine("File is closed");
        }
    }

}
