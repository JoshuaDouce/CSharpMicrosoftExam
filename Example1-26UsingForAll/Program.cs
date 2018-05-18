using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_26UsingForAll
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);

            var parallelResult = numbers.AsParallel()
                .Where(i => i % 2 == 0);

            //ForAll iterates over the collection in a parallel way however removes any sort of ordering 
            //precioously specified
            parallelResult.ForAll(e => Console.WriteLine(e));
        }
    }
}
