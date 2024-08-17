using System;
using System.Collections.Generic;
using System.Threading.Tasks;

//class Program
//{
//    static async Task Main(string[] args)
//    {
//        // Define a list of tasks
//        List<Task<int>> tasks = new List<Task<int>>
//        {
//            Task.Run(() => PerformTask(1, 2000)),  // Task 1
//            Task.Run(() => PerformTask(2, 1000)),  // Task 2
//            Task.Run(() => PerformTask(3, 3000))   // Task 3
//        };

//        // Wait for all tasks to complete
//        int[] results = await Task.WhenAll(tasks);

//        // Process the results
//        foreach (var result in results)
//        {
//            Console.WriteLine($"Task completed with result: {result}");
//        }
//    }

//    static int PerformTask(int taskId, int delay)
//    {
//        Console.WriteLine($"Task {taskId} started.");
//        Task.Delay(delay).Wait();  // Simulate work
//        Console.WriteLine($"Task {taskId} completed.");
//        return taskId * 10;  // Return some result
//    }
//}



//class Program
//{
//    static async Task Main(string[] args)
//    {
//        // Define a list of tasks
//        Task<int> task1 = Task.Run(() => PerformTask(1, 3000));  // Task 1
//        Task<int> task2 = Task.Run(() => PerformTask(2, 1000));  // Task 2
//        Task<int> task3 = Task.Run(() => PerformTask(3, 2000));  // Task 3

//        // Wait for any one of the tasks to complete
//        Task<int> completedTask = await Task.WhenAny(task1, task2, task3);

//        // Get the result of the completed task
//        int result = await completedTask;

//        Console.WriteLine($"First task completed with result: {result}");
//    }

//    static int PerformTask(int taskId, int delay)
//    {
//        Console.WriteLine($"Task {taskId} started.");
//        Task.Delay(delay).Wait();  // Simulate work
//        Console.WriteLine($"Task {taskId} completed.");
//        return taskId * 10;  // Return some result
//    }
//}


//class Program
//{
//    static void Main(string[] args)
//    {
//        // Create and start a task that returns a value
//        Task<int> task = Task.Run(() => PerformTask(5, 2000));

//        //  (NOT RECOMMENDED)
//        int result = task.Result;  // This will block until the task is complete

//        // Use the result
//        Console.WriteLine($"Task completed with result: {result}");

//        // Example with a list of tasks
//        Task<int> task1 = Task.Run(() => PerformTask(10, 1000));
//        Task<int> task2 = Task.Run(() => PerformTask(20, 3000));
//        Task<int> task3 = Task.Run(() => PerformTask(30, 1500));

//        // Wait for all tasks to complete and get the results
//        Task.WhenAll(task1, task2, task3).Wait();  // Alternatively, you can use Task.WaitAll(task1, task2, task3);

//        // Retrieve and print the results
//        Console.WriteLine($"Task 1 result: {task1.Result}");
//        Console.WriteLine($"Task 2 result: {task2.Result}");
//        Console.WriteLine($"Task 3 result: {task3.Result}");
//    }

//    static int PerformTask(int input, int delay)
//    {
//        Console.WriteLine($"Task with input {input} started.");
//        Task.Delay(delay).Wait();  // Simulate work
//        Console.WriteLine($"Task with input {input} completed.");
//        return input * 2;  // Return some result
//    }
//}


//public class ResultExample
//{
//    public static async Task Main()
//    {
//        var task = Task.Run(
//            () =>
//            {
//                DateTime date = DateTime.Now;
//                return date.Hour > 17
//                   ? "evening"
//                   : date.Hour > 12
//                       ? "afternoon"
//                       : "morning";
//            });

//        await task.ContinueWith(
//            antecedent =>
//            {
//                Console.WriteLine($"Good {antecedent.Result}!");
//                Console.WriteLine($"And how are you this fine {antecedent.Result}?");
//            }, TaskContinuationOptions.OnlyOnRanToCompletion);
//    }
//}




class Program
{
    static void Main(string[] args)
    {
        // Create a CancellationTokenSource
        CancellationTokenSource cts = new CancellationTokenSource(3000);


        try
        {
            // Pass the CancellationToken to the task
            Task task = Task.Run(() => PerformTask(5, 5000, cts.Token), cts.Token);
            task.Wait();
        }
        catch (AggregateException ex)
        {
            foreach (var inner in ex.InnerExceptions)
            {
                if (inner is TaskCanceledException)
                {
                    Console.WriteLine("Task was canceled.");
                }
                else
                {
                    Console.WriteLine($"Exception: {inner.Message}");
                }
            }
        }
        finally
        {
            cts.Dispose();
        }

        Console.WriteLine("Main program has finished.");
    }

    static void PerformTask(int input, int delay, CancellationToken token)
    {
        Console.WriteLine($"Task started with input {input}.");

        for (int i = 0; i < delay / 1000; i++)
        {
            // Check if cancellation was requested
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Cancellation requested. Exiting task...");
            }

            // Simulate work
            Console.WriteLine($"Working...{i+1}");
            Task.Delay(1000).Wait();
        }

        Console.WriteLine($"Task completed");
    }
}
