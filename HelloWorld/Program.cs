//using System;
//using System.Collections.Generic;
//using System.Threading;
//using System.Threading.Tasks;

//namespace AsynchronousProgramming
//{
//    class Program
//    {
//        static async Task Main(string[] args)
//        {
//            await foreach (var name in GenerateNames())
//            {
//                Console.WriteLine(name);
//            }

//            Console.ReadKey();
//        }

//        private static async IAsyncEnumerable<string> GenerateNames()
//        {
//            yield return "Anurag";
//            yield return "Pranaya";
//            await Task.Delay(TimeSpan.FromSeconds(3));
//            yield return "Sambit";
//        }
//    }
//}


using System;
using System.Threading.Tasks;

namespace Csharp8Features
{
    public class NullableReferenceTypes
    {
        static async Task Main(string[] args)
        {
            await foreach (var number in GenerateSequence())
            {
                Console.WriteLine(number);
                Console.WriteLine("Thread id in Main() {0}", Thread.CurrentThread.ManagedThreadId);

            }
        }
        public static async System.Collections.Generic.IAsyncEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(300);

                yield return i;
            }
        }
    }
}


