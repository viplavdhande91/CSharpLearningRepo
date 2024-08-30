using System;


namespace Cal
{
    interface IAuthService
    {
        void Login(int age);
    }

    class AuthConcreteService : IAuthService
    {
        public void Login(int age) {

            Console.WriteLine($"You are Logged in now Because youre age is {age}");
        }
    }

    class AuthProxyService : IAuthService
    {
        private AuthConcreteService _concreteService;

        public AuthProxyService(AuthConcreteService concreteService)
        {
            _concreteService = concreteService;
        }

        public void Login(int age) ///PREVALIDATION IN PROXY CLASS
        {
           if(age< 18 )
            {
                Console.WriteLine("You are to young to see our resources");
            }
           else
            {
                _concreteService.Login(age);
            }
        }
    }

    class Maths
    {

        static void Main(string[] args) {

            AuthConcreteService concreteService = new AuthConcreteService();
            AuthProxyService proxyService = new AuthProxyService(concreteService);

            proxyService.Login(15);

            proxyService.Login(20);
           
            Console.ReadLine();

        }

    };
}