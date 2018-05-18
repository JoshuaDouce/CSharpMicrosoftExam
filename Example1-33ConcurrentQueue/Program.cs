using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_33ConcurrentQueue
{
    internal class Program
    {
        //A Queue is FIFO collection. (First in First Out)
        private static void Main(string[] args)
        {
            var queue = new ConcurrentQueue<int>();

            //Enqueue adds an item to the queue
            queue.Enqueue(42);
            queue.Enqueue(41);
            queue.Enqueue(40);

            //Dequeue removes an item from the front of the queue
            if (queue.TryDequeue(out var result))
            {
                Console.WriteLine($"Dequeued {result}");
            }
        }
    }
}
