using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_49AndOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 42;

            bool result = 0 < value && value < 0; 

            Console.WriteLine(result); //displays false
        }
    }
}
