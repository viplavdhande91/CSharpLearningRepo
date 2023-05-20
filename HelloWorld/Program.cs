using System;

namespace Cal
{

    class Maths
    {

        static void Main() {

            string input = "aabbccddd";

            string result = "";

           Dictionary<char,int> countdict = new Dictionary<char,int>();


           for (int i = 0; i < input.Length; i++)
            {
                if (countdict.ContainsKey(input[i]))
                {
                    countdict[input[i]] = countdict[input[i]] +  1;

                }
                else
                {
                    countdict[input[i]] = 1;

                }

            }

          foreach(var item in countdict){

                Console.WriteLine("Key: {0}",item.Key);
                Console.WriteLine( "Value: {0}", item.Value);


            }

          foreach (var item in countdict)
            {
                char key = item.Key;
                String value = item.Value.ToString();

                result += key + value;
            }


            Console.WriteLine(result);







        }



    };



}