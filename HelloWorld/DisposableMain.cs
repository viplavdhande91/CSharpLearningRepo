using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class DisposableMain
    {
        static void Main(string[] args)
        {
            //create object using "using structure"
            using (DisposableDemo s = new DisposableDemo())
            {

                s.DisplayDataFromDatabase();

            }

            Console.WriteLine("Some other work here");

            Console.ReadKey();


        }

    }

    internal class DisposableDemo : System.IDisposable
    {
        //constructor
        public DisposableDemo()
        {
            Console.WriteLine("Database connected.");
        }

        //method
        public void DisplayDataFromDatabase()
        {
            Console.WriteLine("Reading data from database");
        }

        //Dispose
        public void Dispose()
        {
            Console.WriteLine("Database disconnected");
        }
    }
}
