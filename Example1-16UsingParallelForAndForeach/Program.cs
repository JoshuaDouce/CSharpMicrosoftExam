using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Example1_16UsingParallelForAndForeach
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Paralell keyworld allows each item in the for loop to be iterated over asynchronously
            Parallel.For(0, 10, i=> {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            });

            //Set an enumerable range of numbers
            var numbers = Enumerable.Range(0, 10);

            //process each item asynchronously
            Parallel.ForEach(numbers, i => {
                Console.WriteLine(i);
                Thread.Sleep(100);
            });
        }
    }
}
