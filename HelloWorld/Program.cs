using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    internal class Program
    {
        static void Main()
        {
            IProgress<int> p = new Progress<int>(progress =>
            {
                Console.WriteLine("Running Step: {0}", progress);
            });
            LongJob(p);
            Console.ReadLine();

        }

        public static void LongJob(IProgress<int> progress)
        {
            var max = 10;
            for (int i = 0; i < max; i++)
            {
                Task.Delay(1000).Wait();
                
                progress.Report(i);
                
            }
        }


    }
}
