using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Innerexception
namespace HelloWorld
{
    public class ThrowInCatchDemoProgram
    {

        //CHAINING OF EXCEPTIONS
        static void Main(string[] args)
        {
            try
            {
                Foo();
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
                String innerMessage = (ex.InnerException != null)
                      ? ex.InnerException.Message
                      : "";
                Console.WriteLine(innerMessage);
            }
        }
        static void Foo()
        {
            try
            {
                Bar();
            }
            catch (DemoException ex)
            {
                //Log....
                //throw ex;
                //throw;
                throw new ApplicationException("Application...", ex);
            }
        }
        static void Bar()
        {
            throw new DemoException("Demo...", 10);
        }
    }
}
