using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_33ConcurrentQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
            queue.Enqueue(42);

            int result;

            if (queue.TryDequeue(out result))
            {
                Console.WriteLine("Dequeued {0}", result);
            }
        }
    }
}
