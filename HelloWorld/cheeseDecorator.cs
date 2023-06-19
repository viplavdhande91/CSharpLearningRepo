using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class cheeseDecorator : BasePizzaDecorator
    {
        public cheeseDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\nwith extra cheese";
            return type;
        }
    }
}
