using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace Example1_28BlockingCollection
{
    internal class Program
    {
        //A blockin g collection is a thread safe collection for adding and removing data
        private static void Main(string[] args)
        {
            var col = new BlockingCollection<string>();

            //Listens for new items being added and blocks if no items
            //are available
            var read = Task.Run(() => {
                while (true)
                {
                    Console.WriteLine(col.Take());
                }
            });

            //A task to add an item to a collection
            var write = Task.Run(() => {
                while (true)
                {
                    var s = Console.ReadLine();
                    //If no data is entered terminate
                    if (string.IsNullOrWhiteSpace(s)) break ;
                    col.Add(s);
                }
            });

            write.Wait();
        }
    }
}
