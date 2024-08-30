using System;

namespace DecoratorPattern
{
    //COMPONENT
    interface IPizza
    {
        string MakePizza();
    }

    //CONCRETE COMPONENT
    class Pizza : IPizza
    {
        public string MakePizza()
        {
            return "This is plain Pizza\n";
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

        public virtual string MakePizza()
        {
            return "this is Round Shaped pizza\n";
        }
    }

    //CONCRETE DECORATOR 1 CLASS

    class cheeseDecorator : BasePizzaDecorator
    {
        public cheeseDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string MakePizza()
        {
            string type = base.MakePizza();
            type += "\nwith extra cheese\n";
            return type;
        }
    }
    //CONCRETE DECORATOR 2 CLASS

    class TomatoDecorator : BasePizzaDecorator
    {
        public TomatoDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string MakePizza()
        {
            string type = base.MakePizza();
            type += "\nwith extra Tomato\n";
            return type;
        }
    }
    class Program
    {

        static void Main(string[] args) { 
         IPizza pizza = new Pizza();
         IPizza cheesePizaa = new cheeseDecorator(pizza);

         IPizza tomatoAddedPizza = new TomatoDecorator(cheesePizaa);

        Console.WriteLine(tomatoAddedPizza.MakePizza());

        Console.WriteLine(cheesePizaa.MakePizza());

        Console.ReadKey();

        }
    }


















}