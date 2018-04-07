using System;
using System.Threading;

namespace CSharpExam
{
    class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProcess: {0}", i);
                Thread.Sleep(2);
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for (int i = 0; i < 4; i++)
            {
                System.Console.WriteLine("Main Thread: Do Some Work");
                Thread.Sleep(3);
            }

            t.Join();
        }
    }
}
