using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DisplayTemp(DateTime.Now, 23.1456));
        }

        public static string DisplayTemp(DateTime date, double temp) {
            string output;

            //First value in the format {x:y} refers to the variable for example 0:t says use the date variable
            //The second value is the format of the data
            output = string.Format("Temperature at {0:hh:mm} on {0:d} is {1:N1}", date, temp);

            string lblMessage = output;

            return lblMessage;
        }
    }
}
