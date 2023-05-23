using System;

namespace Cal
{

    class Maths
    {

        static void Main() {

           Dictionary<string,int> mydict = new Dictionary<string, int>();


            mydict.Add("a", 1);
                
            mydict.Add("b", 2);
            mydict.Add("c", 3);
                
            
            Console.WriteLine(mydict.ToString());

            
            foreach (var item in mydict) { 

                Console.WriteLine("Key is {0} Value is {1}",item.Key,item.Value  );
            
            }


        }



    };



}