
using System.Collections.Concurrent;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Thread Count ", Thread.CurrentThread.ManagedThreadId);
        ConcurrentBag<int> bag = new ConcurrentBag<int>();

        // Parallel task to add items to the bag
        Parallel.For(0, 5, i =>
        {
            bag.Add(i);
            //Console.WriteLine($"Thread id { Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"Added {i}");
        });

        // Parallel task to read items from the bag
        Parallel.For(0, 5, i =>
        {
            if (bag.TryTake(out int result))
            {
                //Console.WriteLine($"Thread id extract {Thread.CurrentThread.ManagedThreadId}");
                Console.WriteLine($"Took outside {result}");
            }
        });

        // Final count of items in the bag
        Console.WriteLine($"Final count of items in the bag: {bag.Count}");
    }
}

