namespace AsyncAwaitDemo;

internal class Program
{
    static void Main()
    {
        var p = new Progress<int>(progress =>
        {
            Console.WriteLine("Running Step: {0}", progress);
        });

        LongJob(p);
        Console.ReadLine();
    }

    public static void LongJob(IProgress<int> p1)
    {
        var max = 10;
        for (int i = 0; i < max; i++)
        {
            Task.Delay(1000).Wait();
            p1.Report(i);

        }
    }

}
