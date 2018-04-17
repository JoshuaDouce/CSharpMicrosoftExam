using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_78Contravariance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Because DoSomething can work with a text writer it can also work with a stream writer.
            //This is contravariance.
            ContravarianceDel del = DoSomething;
        }

        static void DoSomething(TextWriter tw) { }

        public delegate void ContravarianceDel(StreamWriter tw);
    }
}
