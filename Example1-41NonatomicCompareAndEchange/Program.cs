using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Example1_41NonatomicCompareAndEchange
{
    class Program
    {
        static int value = 1;

        static void Main(string[] args)
        {
            Task t1 = Task.Run(() => {
                if (value == 1)
                {
                    //Removing the following line will chnage the output
                    Thread.Sleep(1000);
                    value = 2;
                }
            });

            Task t2 = Task.Run(() => {
                value = 3;
            });

            Task.WaitAll(t1, t2);

            Console.WriteLine(value); //displays 2 sometimes

            AtomicExchange();
        }

        public static void AtomicExchange() {
            Task t1 = Task.Run(() => {
                if (value == 1)
                {
                    //Using interlocked compare exhange allows you to swap values atomically
                    Thread.Sleep(1000);
                    Interlocked.CompareExchange(ref value, 2, value);
                }
            });

            Task t2 = Task.Run(() => {
                Interlocked.CompareExchange(ref value, 3, value);
            });

            Task.WaitAll(t1, t2);

            Console.WriteLine(value); //displays 3 always
        }
    }
}
