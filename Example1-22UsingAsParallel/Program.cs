using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_22UsingAsParallel
{
    internal class Program
    {
        //The runtime determines whether it makes sense to turn you query into a parallel one.
        //You can force this using the WithExecutioMethodMode method
        private static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 1000000);

            //The enumerabe collection has to be marked AsParallel first in order to run asynchronously
            var parallelResult = numbers.AsParallel()
                .Where(i => i % 2 == 0)
                .ToArray();

            var array = new[] {1, 2, 3, 4, 5};

            var parellelOutput = array.AsParallel().Where(i => i % 2 == 0).ToArray();

            Console.WriteLine(parellelOutput.Length);
        }
    }
}
