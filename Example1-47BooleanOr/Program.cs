using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_47BooleanOr
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            bool y = false;

            bool result = x || y;

            Console.WriteLine(result);//displays true
        }
    }
}
