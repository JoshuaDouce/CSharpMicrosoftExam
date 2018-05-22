using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Question8_1
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        [XmlRoot("Prospect", Namespace="http://prospect")]//Specifies a namespace for the class
        public class Customer {

            [XmlAttribute("ProspectID")]//Specfies an XML attribute for the prospect ID
            public Guid Id { get; set; }

            [XmlElement("FullName")]// specifies the xmlelement fullName
            public string Name { get; set; }

            //If no attribute is specified will be seriliazed
            public DateTime DOB { get; set; }

            [XmlIgnore]//Ignores this field when serializing
            public int Tin { get; set; }
        }
    }   
}
