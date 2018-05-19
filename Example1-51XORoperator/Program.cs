using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_51XORoperator
{
    class Program
    {
        //The exclusive or checks that exactly one is true so does not apply short circuting.
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            bool c = true;

            Console.WriteLine(a ^ b);//Displays true
            Console.WriteLine(a ^ c);//Displays false
        }
    }
}
