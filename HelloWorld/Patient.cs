using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HelloWorld
{
    public class Patient
    {
        public int ID { get; set; }
        [XmlElement, DefaultValue("")]
        public string? FirstName { get; set; }
        [XmlElement, DefaultValue("")]

        public string? LastName { get; set; }
        public DateTime Birthday { get; set; }
        public int RoomNo { get; set; }
    }
}
