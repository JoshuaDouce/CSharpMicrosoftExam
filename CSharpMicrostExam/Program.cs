using System;
using System.Threading;

namespace CSharpMicrostExam
{
    //An example to show the creation and execution of s process on a new thread
    internal class Program
    {
        public static void ThreadMethod()
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"ThreadProcess: {i}");
                //Simulates a longer running task by slepping the operation
                Thread.Sleep(2);
            }
        }

        public static void Thread2Method()
        {
            for (var i = 0; i < 7; i++)
            {
                Console.WriteLine($"ThreadProcess2: {i}");
                //Simulates a longer running task by slepping the operation
                Thread.Sleep(5);
            }
        }

        public static void Thread3Method()
        {
            for (var i = 0; i < 7; i++)
            {
                Console.WriteLine("Thread 3 is working");
                //Simulates a longer running task by slepping the operation
                Thread.Sleep(10);
            }
        }

        private static void Main(string[] args)
        {
            //Create a new thread that will execute the thread method
            var t = new Thread(ThreadMethod);

            //Create a second thread
            var t2 = new Thread(Thread2Method);

            //Create a 3rd thread
            var t3 = new Thread(Thread3Method);

            //Use .start() to start the thread
            t.Start();
            t2.Start();
            t3.Start();

            //Task executed on the main thread
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Main Thread: Do Some Work");
                Thread.Sleep(3);
            }

            //Join the thread back to the main thread
            t.Join();
            t2.Join();
            t3.Join();
        }
    }
}
