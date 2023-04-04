using System;
namespace Cal
{

    public partial class Geeks
    {
        private string Author_name;
        private int Total_articles;

        public Geeks(string a, int t)
        {
            this.Author_name = a;
            this.Total_articles = t;
        }
    }


    public partial class Geeks
    {
        public void Display()
        {
            Console.WriteLine("Author's name is : " + Author_name);
            Console.WriteLine("Total number articles is : " + Total_articles);
        }
    }


    public class Program
    {

        public static void Main(string[] args)
        {

            Geeks geek = new Geeks("Viplav Patil", 72);
            geek.Display();

        }
    }
}