using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_79LambdaToCreateDelegate
{
    class Program
    {
        public delegate int Calculate(int x, int y);

        static void Main(string[] args)
        {
            //can be read literally as x, y goes to x + y;
            Calculate calc = (x, y) => x + y;
            Console.WriteLine(calc(3,4));//displays 7

            calc = (x, y) => x * y;
            Console.WriteLine(calc(3, 4));//displays 12

            //return types are automatically infered when using lambdas
        }
    }
}
