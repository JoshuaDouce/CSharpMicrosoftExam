using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Concurrent;

namespace Example1_31EnumeratingConcurrentBag
{
    internal class Program
    {

        //Concurrent bag implement IEnumerable of T.
        //This is made threadsafe by taking a snapshot of the collection when you begin iterating.
        //Items added after iterating starts will not be visible
        private static void Main(string[] args)
        {
            var bag = new ConcurrentBag<int>();

            Task.Run(() => {
                bag.Add(42);
                Thread.Sleep(1000);
                bag.Add(21);
            });

            Task.Run(() => {
                foreach (var i in bag)
                {
                    Console.WriteLine(i);
                }
            }).Wait();
        }
    }
}
