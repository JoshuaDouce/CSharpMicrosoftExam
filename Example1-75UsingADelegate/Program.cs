using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_75UsingADelegate
{
    class Program
    {
        //a delegate that points to a methid that returns an int and takes 2 parameters of type int
        public delegate int Calculate(int x, int y);

        public static int Add(int x, int y) { return x + y; }
        public static int Multiply(int x, int y) { return x * y; }

        public static void UseDelegate() {
            Calculate calc = Add;
            Console.WriteLine(calc(3 ,4)); //displays 7

            calc = Multiply;
            Console.WriteLine(calc(3, 4)); //displays 12
        }

        static void Main(string[] args)
        {
            UseDelegate();
        }
    }
}
