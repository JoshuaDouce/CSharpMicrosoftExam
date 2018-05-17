using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Example1_7QueuingUsingThreadPool
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //The thread pool manages your threads for you, This shows the thread pool queing a new item
            //This is useful in a web service for example where you dont want to manually spin up a thread for each
            //request. This could easily crash the server.
            //The thread pool will manage the number of threads and queue any tasks until a thread becomes available.
            ThreadPool.QueueUserWorkItem((s) => {
                Console.WriteLine("Working on a thread from threadpool");
            });

            ThreadPool.QueueUserWorkItem((t) =>
            {
                Console.WriteLine("Working on another thread from the thread pool");
            });

            Console.ReadLine();
        }
    }
}
