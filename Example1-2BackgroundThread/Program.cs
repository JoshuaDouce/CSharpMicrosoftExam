using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Example1_2BackgroundThread
{
    internal class Program
    {
        public static void ThreadMethod() {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"ThreadProcess: {i}");
                Thread.Sleep(1000);
            }
        }

        private static void Main(string[] args)
        {
            var t = new Thread(ThreadMethod)
            {
                //This setting specifies if the tread is a background or a foreground thread.
                //If true console app will exit immediately as when all foreground threads finish the app terminates
                //if false will execute as a foreground thread and will display the count
                IsBackground = false
            };
            t.Start();
        }
    }
}
