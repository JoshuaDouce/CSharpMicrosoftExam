using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace Example1_30ConcurrentBag
{
    internal class Program
    {
        //The concurrent bag us just a bag if items. It enables duplication and
        //has no particular order
        private static void Main(string[] args)
        {
            var bag = new ConcurrentBag<int> {42, 21};

            //Try take will get the next item
            if (bag.TryTake(out var result))
            {
                Console.WriteLine(result);
            }

            //Try peek will check if there is another item in the bag
            //Not very useful in multithreaded environment as another tthread could remove the item
            if (bag.TryPeek(out result))
            {
                Console.WriteLine($"There is a next item: {result}");
            }
        }
    }
}
