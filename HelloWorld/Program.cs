using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton obj1 = Singleton.MyObject();
            obj1.mymethod();
            Singleton obj2 = Singleton.MyObject();
            obj2.mymethod();
            Console.ReadLine();
        }
    }
    sealed class Singleton
    {
        private Singleton()
        {

        }
        public static Singleton? getinstnace = null;
        public static Singleton MyObject()
        {
            if (getinstnace == null)
            {
                return new Singleton();
            }
            return getinstnace;
        }
        public void mymethod()
        {
            Console.WriteLine("This is my Method");
        }
    }
}