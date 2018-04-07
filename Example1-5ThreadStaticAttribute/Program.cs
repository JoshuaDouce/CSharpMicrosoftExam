using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Example1_5ThreadStaticAttribute
{
    class Program
    {
        //Makes the static variable only available to the single thread. 
        //Removing this allows each thread acces to same variable
        [ThreadStatic]
        public static int _field;

        static void Main(string[] args)
        {
            new Thread(() => {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread A: {0}", _field);
                }
            }).Start();

            new Thread(() => {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread B: {0}", _field);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}
