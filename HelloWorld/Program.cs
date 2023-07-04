using System;


namespace Cal
{


    class Maths
    {


        public static int fibonacci(int number) {

            if (number == 0 || number == 1)
                return number;

            else { 
            
            
            return fibonacci(number - 1) + fibonacci(number-2);
            }

        
        
        
        
        }
        





        static void Main(string[] args) {
            Console.Write("Enter the length of the Fibonacci Series: ");
            int length = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", fibonacci(i));
            }
            Console.ReadKey();




        }



    };



}