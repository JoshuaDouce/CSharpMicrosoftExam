using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_50ShortcircuitingAnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Process("Very"));//Displays True
            Console.WriteLine(Process("They"));//Displays False
            Console.WriteLine(Process(null));//Displays False
        }

        private static bool Process(string input) {
            //If short circuiting did not occur here the code would throw an exception
            bool result = input != null && input.StartsWith("V");
            return result;
        }
    }
}
