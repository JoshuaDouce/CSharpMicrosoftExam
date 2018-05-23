using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.Web.Script.Serialization;

namespace UsingJavascriptSerializer
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public class Name
        {
            public int[] Values { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public static Name ConvertToName(string json) {

            var ser = new JavaScriptSerializer();

            //<class deserialize to>(string to deserialize)
            return ser.Deserialize<Name>(json);
        }
    }
}
