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
            Singleton.Hit();
            Console.WriteLine(Singleton.getTotalHits().ToString());


            Singleton.Hit();
            Console.WriteLine(Singleton.getTotalHits().ToString());

             Singleton.Hit();
            Console.WriteLine(Singleton.getTotalHits().ToString());

            Console.ReadLine();
        }
    }
    sealed class Singleton
    {
        public static int intCounter;
        private Singleton()
        {
            // This is a private constructor
        }
        public static void Hit()
        {
            intCounter++;
        }
        public static int getTotalHits()
        {
            return intCounter;
        }
    }
}
