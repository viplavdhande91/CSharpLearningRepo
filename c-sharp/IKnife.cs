using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// Product
    /// </summary>
    public interface  IKnife
    {
        public  void Sharpen();
        public  void Polish();
        public  void Package();
    }

    public class ChefKnife : IKnife
    {
        public  void Sharpen()
        {
            Console.WriteLine("Sharpening the chef knife.");
        }

        public  void Polish()
        {
            Console.WriteLine("Polishing the chef knife.");
        }

        public  void Package()
        {
            Console.WriteLine("Packaging the chef knife.");
        }
    }

    public class SteakKnife : IKnife
    {
        public  void Sharpen()
        {
            Console.WriteLine("Sharpening the steak knife.");
        }

        public  void Polish()
        {
            Console.WriteLine("Polishing the steak knife.");
        }

        public  void Package()
        {
            Console.WriteLine("Packaging the steak knife.");
        }
    }

}
