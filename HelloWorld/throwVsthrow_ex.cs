using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class throwVsthrow_ex
    {

        static void Main(string[] args)
        {
            try
            {

                DivideByZero();
            }
            catch(Exception ex) {

                Console.WriteLine(ex.StackTrace);
            }
            
        }


       public static void DivideByZero()
        {
            try
            { 
               int i =0, j = 0;
               int result = i / j;


            }
            catch(Exception 
            ) {

                throw;
                //throw ex;
            }


        }


    }
}
