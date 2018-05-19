using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_46UsingEqualityOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 42;
            int y = 1;
            int z = 42;

            Console.WriteLine(x == y);//Displays false
            Console.WriteLine(x == z);//Displays true
        }
    }
}
