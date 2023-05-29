using System;
using System.IO;
using System.Xml.Serialization;


namespace HelloWorld
{
    public class XMLSerializationExample
    {
        public static void Main(string[] args)
        {

            //SERIALIZATION
            var patient = new Patient()
            {
                ID = 232323,
                FirstName = "John",
                LastName = "Doe",
                Birthday = new DateTime(1990, 12, 30),
                RoomNo = 310
            };

            string path_ = Directory.GetCurrentDirectory() + @"\patients.xml";
            FileStream stream_ = new FileStream(path_, FileMode.OpenOrCreate);
            XmlSerializer serializer = new XmlSerializer(typeof(Patient));
            serializer.Serialize(stream_, patient);
            stream_.Close();



            //DESERIALIZE
            string path = Directory.GetCurrentDirectory() + @"\patients.xml";
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            XmlSerializer deserial = new XmlSerializer(typeof(Patient));

            Patient? paTient = (Patient?) deserial.Deserialize(stream);

            if(paTient != null) {
                Console.WriteLine("Employee Id: " + paTient.ID);
                Console.WriteLine("Employee Name: " + paTient.FirstName);
            }
               
            

            stream.Close();
            Console.ReadLine();

        }
    }
}