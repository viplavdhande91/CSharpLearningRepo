using System;


namespace Cal
{
    interface IService
    {
        void Login(int age);
    }


    class ConcreteService : IService
    {
        public void Login(int age) {

            Console.WriteLine($"You are Logged in now Because youre age is {age}");
        }
    }

    class ProxyService : IService
    {
        private IService _service;

        public ProxyService(IService serivce)
        {
            _service = serivce;
        }

        public void Login(int age)
        {
           if(age< 18 )
            {
                Console.WriteLine("You are to young to see our resources");
            }
           else
            {
                _service.Login(age);
            }
        }
    }

    class Maths
    {

        static void Main(string[] args) {

            IService concreteService = new ConcreteService();
            IService proxyService = new ProxyService(concreteService);

            proxyService.Login(15);

            proxyService.Login(20);
           
            Console.ReadLine();

        }



    };



}