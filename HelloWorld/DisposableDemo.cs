using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
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
