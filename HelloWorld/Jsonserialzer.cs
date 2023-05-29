using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Jsonserialzer
    {
        public static void Main(string[] args)
        {
            Patient patient = new Patient()
            {
                ID = 232323,
                FirstName = "John",
                LastName = "Doe",
                Birthday = new DateTime(1990, 12, 30),
                RoomNo = 310
            };
            // Serialization
            string jsonString = JsonConvert.SerializeObject(patient);

            Console.WriteLine("After Serializing {0}",jsonString);


            //Deserialize
            Patient? deserializedPatient= JsonConvert.DeserializeObject<Patient>(jsonString);



            if (deserializedPatient != null)
            {
                Console.WriteLine("Employee Id: " + deserializedPatient.ID);
                Console.WriteLine("Employee Name: " + deserializedPatient.FirstName);
            }

        }
    }
}
