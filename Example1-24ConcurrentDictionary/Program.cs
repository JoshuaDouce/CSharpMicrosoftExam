using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_24ConcurrentDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new ConcurrentDictionary<string, int>();

            if (dict.TryAdd("k1", 42))
            {
                Console.WriteLine("Added");
            }

            if (dict.TryUpdate("k1", 21, 42))
            {
                Console.WriteLine("42 updated to 21");
            }

            dict["k1"] = 42; //overrite unconditionally

            int r1 = dict.AddOrUpdate("k1", 3, (s, i) => i * 2);
            int r2 = dict.GetOrAdd("k2", 3);
        }
    }
}
