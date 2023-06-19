using System;
using System.Collections.Generic;
using static System.Console;

namespace HelloWorld
{
    public class Program
    {
        /// Singleton Design Pattern

        public static void Main()
        {
            var b1 = LoadBalancer.GetLoadBalancer();
            var b2 = LoadBalancer.GetLoadBalancer();
            var b3 = LoadBalancer.GetLoadBalancer();
            var b4 = LoadBalancer.GetLoadBalancer();

            // Confirm these are the same instance

            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                WriteLine("Same instance\n");
            }

            // Next, load balance 15 requests for a server

            var balancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                string serverName = balancer.NextServer.Name;
                WriteLine("Dispatch request to: " + serverName);
            }

            // Wait for user

            ReadKey();
        }
    }

    /// <summary>
    /// The 'Singleton' class
    /// </summary>

}