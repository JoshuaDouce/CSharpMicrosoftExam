using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_76MulticastDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiCast();
        }

        public static void MethodOne() {
            Console.WriteLine("MethodOne");
        }

        public static void MethodTwo() {
            Console.WriteLine("MethodTwo");
        }

        public delegate void Del();

        public static void MultiCast() {
            Del d = MethodOne;
            d += MethodTwo;

            d();
        }
    }
}
