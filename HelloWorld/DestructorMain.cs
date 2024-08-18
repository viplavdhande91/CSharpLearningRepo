
using System;

namespace Cal
{
    class Maths
    {
        static void Main() {

           //create object of Sample class
           DestructorDemo s = new DestructorDemo();
        } //destructor gets called here automatically

    };

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