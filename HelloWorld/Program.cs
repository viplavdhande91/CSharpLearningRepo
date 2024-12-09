using System.Collections.Concurrent;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Thread Count ", Thread.CurrentThread.ManagedThreadId);
        ConcurrentBag<int> bag = new ConcurrentBag<int>();

        // Parallel task to add items to the bag
        Parallel.For(0, 3, i =>
        {
            bag.Add(i);
            Console.WriteLine($"Thread id {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"Added {i}\n");
        });

        // Parallel task to read items from the bag
        Parallel.For(0, 3, i =>
        {
            if (bag.TryTake(out int result))
            {
                Console.WriteLine($"Thread id extract {Thread.CurrentThread.ManagedThreadId}");
                Console.WriteLine($"Took outside {result}\n");
            }
        });

        // Final count of items in the bag
        Console.WriteLine($"Final count of items in the bag: {bag.Count}");
    }
}

//Thread safe collections such as ConcurrentBag should be used in MultiThreadded Environment