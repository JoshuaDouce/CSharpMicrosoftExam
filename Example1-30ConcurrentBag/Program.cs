using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace Example1_30ConcurrentBag
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();

            bag.Add(42);
            bag.Add(21);

            int result;

            if (bag.TryTake(out result))
            {
                Console.WriteLine(result);
            }

            if (bag.TryPeek(out result))
            {
                Console.WriteLine("There is a next item: {0}", result);
            }
        }
    }
}
