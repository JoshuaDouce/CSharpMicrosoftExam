using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_25ParalellQuerySequential
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);

            var paralellResult = numbers.AsParallel().AsOrdered().
                Where(i => i % 2 == 0).AsSequential();

            foreach (var i in paralellResult.Take(5))
            {
                Console.WriteLine(i);
            }
        }
    }
}
