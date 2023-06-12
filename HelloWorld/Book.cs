using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Book
    {
        public string bookName;

        public double bookPrice;
        public Book(string name,double price) {
            bookName = name;
            bookPrice = price;
        
        }
    }
}
