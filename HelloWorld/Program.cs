using System;
namespace Cal
{

    public class Student
    {
        public int id;
        public string? name;


    }

    class Maths
    {



        static void Main(string[] args)
        {
            
            List<Student> studentList = new List<Student>();

            studentList.Add(new Student { id = 1, name = "Viplav" });
            studentList.Add(new Student { id = 2, name = "Ganesh" });
            studentList.Add(new Student { id = 3, name = "Suresh" });

            IEnumerable<Student> students = studentList;



            foreach (var student in studentList)
            {
                Console.WriteLine($"{student.id} +'    '+  {student.name}");

            }



        }



    };



}