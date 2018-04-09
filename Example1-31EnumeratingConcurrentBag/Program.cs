using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Concurrent;

namespace Example1_31EnumeratingConcurrentBag
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();

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
