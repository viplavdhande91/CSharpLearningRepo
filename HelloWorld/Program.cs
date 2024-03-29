using HelloWorld;
using System;

namespace Cal
{

    class Maths
    {

        static void Main(string[] args) {


           //1. USE OF WHERE ,ORDERBY AND SELECT
            List<Book> books = new List<Book>(){new Book("OS by Galvin" ,745),
                                        new Book("TOC by Krishnamurty" ,45),
                                        new Book("CN by Forouzan" ,363),
                                        new Book("DBMS by Silberchatz" ,85),
                                        new Book("Discrete Maths " ,77),
                                    };


            var selectedBooksPrice = books.Where(b => b.bookPrice > 84).OrderBy(b=>b.bookPrice).Select(b=>b.bookName);

            //foreach (var book in selectedBooksPrice) {
            //Console.WriteLine(book);
            //}



            //2. USE OF WHERE ,ORDERBY AND SELECT
            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 15 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
            new Student() { StudentID = 5, StudentName = "Mike" , Age = 15 }};

            var groupedResult = studentList.OrderBy(b => b.StudentName).GroupBy(b =>b.Age);

            //foreach (var ageGroup in groupedResult)
            //{
            //    Console.WriteLine("Age Group: {0}", ageGroup.Key);  //Each group has a key 

            //    foreach (Student s in ageGroup)  //Each group has a inner collection  
            //        Console.WriteLine("Student Name: {0}", s.StudentName);
            //}






            //3. JOIN  [USE LINQ QUERY SYNTAX METHOD]
            IList<Student> studentList1 = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13, StandardID =1 },
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21, StandardID =1 },
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID =2 },
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID =3 },
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

                        IList<Standard> standardList = new List<Standard>() {
                new Standard(){ StandardID = 1, StandardName="Standard 1"},
                new Standard(){ StandardID = 2, StandardName="Standard 2"},
                new Standard(){ StandardID = 4, StandardName="Standard 3"}
            };

            var innerJoin = from s in studentList1 // outer sequence
                            join st in standardList //inner sequence 
                            on s.StandardID equals st.StandardID // key selector 
                            select new
                            { // result selector 
                                StudentName = s.StudentName,
                                StandardName = st.StandardName
                            };

            //foreach (var obj in innerJoin)
            //{

            //    Console.WriteLine("{0} - {1}", obj.StudentName, obj.StandardName);
            //}

        }


    };



}