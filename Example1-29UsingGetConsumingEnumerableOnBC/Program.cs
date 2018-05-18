using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_29UsingGetConsumingEnumerableOnBC
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var col = new BlockingCollection<string>();

            var read = Task.Run(() => {
                //Using the get consuming enumerable method you get an IEnumerable that blocks until it finds a new item
                foreach (var v in col.GetConsumingEnumerable())
                {
                    Console.WriteLine(v);
                }
            });

            var write = Task.Run(() => {
                while (true)
                {
                    var s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s)) break;
                    col.Add(s);
                }
            });

            write.Wait();
        }
    }
}
