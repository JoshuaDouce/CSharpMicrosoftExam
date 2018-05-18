using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_23UnorderedParallelQuery
{
    internal class Program
    {
        //dislpays an undordered list of multiples of 2
        //parallel processing of collections does not guarantee any order.
        private static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 10);
            var paralellResult = numbers.AsParallel()
                .Where(i => i % 2 == 0)
                .ToArray();

            foreach (var i in paralellResult)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("---------");

            //an enumerable collection of numbers
            var moreNumbers = Enumerable.Range(0, 50);

            //process the list as parallel and return the result
            var unorderedResult = moreNumbers.AsParallel()
                .Where(i => i % 2 == 1)
                .ToArray();

            foreach (var number in unorderedResult)
            {
                Console.WriteLine(number);
            }
        }

    }
}
