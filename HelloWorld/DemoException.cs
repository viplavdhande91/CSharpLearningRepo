using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{

    //BOILERPLATE TEMPLATE TO WRITE CUSTOM EXCEPTION
  
        [Serializable]
        class DemoException : Exception
        {
            public readonly int Number;
            public DemoException()
            { }
            public DemoException(string message, int number): base(message)
            {
                Number = number;
            }
            public DemoException(string message, Exception inner, int number): base(message, inner)
            {
                this.Number = number;
            }
        
    }
}
