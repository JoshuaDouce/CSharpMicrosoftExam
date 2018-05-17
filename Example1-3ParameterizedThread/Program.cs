using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Example1_3ParameterizedThread
{
    internal class Program
    {
        //A method the thread will execute that takes a parameter
        public static void ThreadMethod(object o)
        {
            //Here object o has been explicitly cast to an int in this case as its the expected type
            for (var i = 0; i < (int)o; i++)
            {
                Console.WriteLine($"ThreadProc: {i}");
                Thread.Sleep(0);
            }
        }

        //A method the thread will execute that takes a parameter
        public static void ThreadMethod2(object o)
        {
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine($"{o}:{i}");
            }
        }

        private static void Main(string[] args)
        {
            //Create a new thread using the parameterized method
            var t = new Thread(ThreadMethod);
            var t2 = new Thread(ThreadMethod2);
            
            //Start the method and pass the parameter, method will execute with this parameter
            t.Start(5);
            t2.Start("Executing");

            //Join back to the main thread
            t.Join();
            t2.Join();
        }
    }
}
