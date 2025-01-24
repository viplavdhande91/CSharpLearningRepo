
namespace AsyncAwaitDemo;

internal class Program
{
    static void Main()
    {
        Task task = Task1();
        task = Task2();
        task = Task3();
        task = Task4();
        Console.ReadLine();
    }

    public static async Task Task1()
    {
        await Task.Run(() =>
        {
            Console.WriteLine("Task 1 Starting..");
            Thread.Sleep(4000);
            Console.WriteLine("Task 1 Completed..");
        });
        Console.WriteLine("Hello Adil....");
    }

    public static async Task Task2()
    {
        await Task.Run(() =>
        {
            Console.WriteLine("Task 2 Starting..");
            Thread.Sleep(2000);
            Console.WriteLine("Task 2 Completed..");
        });

    }

    public static async Task Task3()
    {
        await Task.Run(() =>
        {
            Console.WriteLine("Task 3 Starting..");
            Thread.Sleep(5000);
            Console.WriteLine("Task 3 Completed..");
        });


    }

    public static async Task Task4()
    {
        await Task.Run(() =>
        {
            Console.WriteLine("Task 4 Starting..");
            Thread.Sleep(1000);
            Console.WriteLine("Task 4 Completed..");
        });

    }
}
