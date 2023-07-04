using System;
namespace Cal
{
    public delegate void DelCalc(int a, int b);

    class Arithmetic
    {

        public static void Addition(int a, int b)
        {

            Console.WriteLine("Result of Addition is {0}",a+b);


        }
        public static void Subtraction(int a, int b)
        {

            Console.WriteLine("Result of Subtraction is {0}",a-b);


        }
        public static void Multiplication(int a, int b)
        {

            Console.WriteLine("Result of Multiplication is {0}",a*b);
        }



         
        public static void Main(string[] args){


            DelCalc delc = new DelCalc(Addition);

            delc += Subtraction;

            delc+= Multiplication;

            delc.Invoke(2, 5);

            // delc(2,3);
           

        }


    } 


}