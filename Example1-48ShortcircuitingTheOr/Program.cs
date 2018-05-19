using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_48ShortcircuitingTheOr
{
    class Program
    {
        static void Main(string[] args)
        {
            ShortCircuit();
        }

        public static void ShortCircuit() {
            bool x = true;

            //If the runtime sees the first part of th eor is true it wont bother checking the other half
            bool result = x || GetY();

            Console.WriteLine(result);
        }

        private static bool GetY()
        {
            Console.WriteLine("You wont see this as it is never called");
            return true;
        }
    }
}
