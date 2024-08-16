using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Stocks
    {

        public static void stocksMethod()
        {
            getJsonData();
        }

        public static async Task getJsonData()
        {
            List<int> arr = new List<int>() { 10, 22, 33, 44, 55 };
            try
            {

                for (int i = 0;i < 10;i++) { 

                    Console.WriteLine(arr[i]);
                }

            }
            catch (Exception ex)
            {
                int x = 5;
                throw ;
            }
        }
    }


}
        