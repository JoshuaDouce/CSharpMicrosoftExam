using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Example1_7QueuingUsingThreadPool
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem((s) => {
                Console.WriteLine("Working on a thread from threadpool");
            });

            Console.ReadLine();
        }
    }
}
