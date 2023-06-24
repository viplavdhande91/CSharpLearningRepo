using System;


namespace Cal
{


    class Maths
    {

        public static void GetNextName(ref int id)
        {
        id += 1;
        }
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("Previous value of integer i:" + i.ToString());
             GetNextName(ref i);
            Console.WriteLine("Current value of integer i:" + i.ToString());
        }



    };



}

//using System;


//namespace Cal
//{


//    class Maths
//    {

//        public static void GetNextName(out int id, out int jd)
//        {

//            id = 1;
//            jd = 2;

//        }
//        static void Main(string[] args)
//        {
//            int id;
//            int jd;
//            GetNextName(out id, out jd);

//            Console.WriteLine($"{id}   {jd}");
//        }



//    };



//}