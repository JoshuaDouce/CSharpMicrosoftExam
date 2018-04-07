using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Example1_2BackgroundThread
{
    class Program
    {
        public static void ThreadMethod() {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProcess: {0}" , i);
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            //if true console app will exit immediately
            //if false will execute as a foreground thread and will display count
            t.IsBackground = false;
            t.Start();
        }
    }
}
