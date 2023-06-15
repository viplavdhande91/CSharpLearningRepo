using HelloWorld;
using System;

namespace Cal
{


    class Maths
    {

        static void Main(string[] args) {

        var books = new List<Book>(){   new Book("OS by Galvin" ,745.65),
                                        new Book("TOC by Krishnamurty" ,45.65),
                                        new Book("CN by Forouzan" ,363),
                                        new Book("DBMS by Silberchatz" ,85.6),
                                        new Book("Discrete Maths " ,77.65),
                                    };


       //USE OF WHERE ,ORDERBY AND SELECT
        var selectedBooksPrice = books.Where(b => b.bookPrice > 85).OrderBy(b=>b.bookPrice).Select(b=>b.bookPrice);

        foreach (var book in selectedBooksPrice) {
            Console.WriteLine(book);

        }


            //Console.WriteLine(selectedBooksPrice.FirstOrDefault(47.36));





        }



    };



}