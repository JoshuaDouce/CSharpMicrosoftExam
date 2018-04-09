using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_24OrderedParalellQuery
{
    class Program
    {
        //displays in order
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel().AsOrdered()
                .Where(i => i % 2 == 0)
                .ToArray();

            foreach (var i in parallelResult)
            {
                Console.WriteLine(i);
            }
        }
    }
}
