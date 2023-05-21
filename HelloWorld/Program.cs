using System;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            int n1, n2;
            n1 = Convert.ToInt32(args[0]);
            n2 = Convert.ToInt32(args[1]);
            int res;
            res = n1 / n2;
            Console.WriteLine("Result:" + res);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("IOR: ");
        }
        catch (FormatException)
        {
            Console.WriteLine("FE: ");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
