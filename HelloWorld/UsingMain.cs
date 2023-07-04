using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class UsingMain
    {
        static void DoWork()
        {
            //create object using "using declaration"
            using DisposableDemo s = new DisposableDemo();
            s.DisplayDataFromDatabase();


        } //Dispose gets called here

        static void Main()
        {
            DoWork();

            Console.WriteLine("Some other work here");

            Console.ReadKey();
        }
    }
}
