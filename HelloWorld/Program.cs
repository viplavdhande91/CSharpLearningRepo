using System;

namespace Cal
{
    public delegate void delCalc(int a, int b);
    class Arithmetic
    {
        public static void Main(string[] args)
        {

           delCalc delg = delegate (int a, int b)
            {
                Console.WriteLine("sum is {0}", a + b);

            };


            delg(1, 2);

        }

    }

}