using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_27CatchingAggregateException
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //When an exceptions is thrown in a paralell task it is cached as an aggregate exception
            var numbers = Enumerable.Range(0, 20);

            //Execute paralell task
            try
            {
                var parallelResult = numbers.AsParallel().Where(i => IsEven(i));

                parallelResult.ForAll(e => Console.WriteLine(e));
            }
            //Catch aggregate exception
            catch (AggregateException e)
            {
                Console.WriteLine($"There where { e.InnerExceptions.Count} exceptions");

                //Loops through the exceptions and displays the messages
                foreach (var exception in e.InnerExceptions)
                {
                    Console.WriteLine("------");
                    Console.WriteLine(exception.Message);
                    Console.WriteLine("-----");
                }
            }

            
        }

        public static bool IsEven(int i) {
            if (i % 10 == 0) throw new ArgumentException("An exception occured");

            return i % 2 == 0;
        }
    }
}
