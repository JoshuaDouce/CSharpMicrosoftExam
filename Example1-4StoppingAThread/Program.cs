using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Example1_4StoppingAThread
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Variable to control if the thread is stopped
            var stopped = false;
            var stoppedThread2 = false;

            //Create a new thread that executes an annoymous method using a lambda
            var t = new Thread(() => {
                //While not stopped
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            });

            var t2 = new Thread(() =>
            {
                while (!stoppedThread2)
                {
                    Console.WriteLine("Running thread 2...");
                    Thread.Sleep(1500);
                }
            });

            //Start the thread
            t.Start();
            t2.Start();
            Console.WriteLine("Press any key to exit the threads");

            //When a key is pressed stop the thread
            Console.ReadKey();

            stopped = true;
            stoppedThread2 = true;

            t.Join();
            t2.Join();
        }
    }
}
