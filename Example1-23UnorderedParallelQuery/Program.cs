using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_23UnorderedParallelQuery
{
    class Program
    {
        //dislpays an undordered list of multiples of 2
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 10);
            var paralellResult = numbers.AsParallel()
                .Where(i => i % 2 == 0)
                .ToArray();

            foreach (var i in paralellResult)
            {
                Console.WriteLine(i);
            }
        }

    }
}
