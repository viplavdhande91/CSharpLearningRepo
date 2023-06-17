using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXPLICIT_IMPLEMENTATION_OF_INTERFACE
{
    interface i1
    {
        void show();
    }
    interface i2
    {
        void show();
    }

    class MyClass : i1, i2
    {

        public void show()
        {
            Console.WriteLine("this is a method of interface i1 !!");
        }

        void i2.show()   //EXPLICIT DECLARATION
        {
            Console.WriteLine("this is a method of interface i2 !!");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {



            MyClass obj = new MyClass();
            obj.show();
            //((i2)obj).show();  //EXPLICIT CALLING

            i2 obj1 = new MyClass();
            obj1.show();


            //((i1)obj).show();
            //((i2)obj).show();

            //i1 obj1 = new MyClass();
            //obj1.show();

            //i2 obj2 = new MyClass();
            //obj2.show();

            Console.ReadLine();
        }
    }
}