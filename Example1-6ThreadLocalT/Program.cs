using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Example1_6ThreadLocalT
{
    internal class Program
    {
        //uses local data in a thread and initializes it for each thread
        //Create new threadLocal variable with a type of int and initialize it
        //This variable contains the current threads managed thread ID.
        public static ThreadLocal<int> _field = new ThreadLocal<int>(() => Thread.CurrentThread.ManagedThreadId);
        public static ThreadLocal<string> _text = new ThreadLocal<string>(() => "Local Variable");

        private static void Main(string[] args){
            new Thread(() => {
                for (var i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine($"Thread A: {i}");
                    Console.WriteLine($"Thread A's {_text}");
                }
            }).Start();

            new Thread(() => {
                for (var i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine($"Thread B: {i}");
                    Console.WriteLine($"Thread B's {_text}");
                }
            }).Start();

            new Thread(() =>
            {
                for (var i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine($"Thread C: {i}");
                    Console.WriteLine($"Thread C's {_text}");
                }
            }).Start();

            Console.ReadKey();
        }
    }
}
