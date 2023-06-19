using System;

//DERIVED DECORATOR CLASS
namespace DecoratorPattern
{
    //BASE INTERFACE
    interface IPizza
    {
        string GetPizzaType();
    }
    // CONCRETE CLASS
    class Pizza : IPizza
    {
        public string GetPizzaType()
        {
            return "This is normal Pizza";
        }
    }

    //BASE DECORATOR CLASS

    class BasePizzaDecorator : IPizza
    {   
        private IPizza _pizza;

        public BasePizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string GetPizzaType()
        {
            return "this is nothing";
        }
    }


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

    class TomatoDecorator : BasePizzaDecorator
    {
        public TomatoDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\nwith extra Tomato";
            return type;
        }
    }
    class Program
    {

        static void Main(string[] args) { 
         IPizza pizza = new Pizza();
         IPizza cheesePizaa = new cheeseDecorator(pizza);

         IPizza tomatoAddedPizza = new TomatoDecorator(cheesePizaa);

         Console.WriteLine(tomatoAddedPizza.GetPizzaType());



        }
    }


















}