using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Example1_5ThreadStaticAttribute
{
    internal class Program
    {
        //By marking the field ThreadStatic each thread gets it own copy of the field
        //Removing this allows each thread acces to same variable
        [ThreadStatic]
        public static int _field;

        //Each thread in the main method when created will have its own copy of the variable,
        //When the program is executed you can see this.
        private static void Main(string[] args)
        {
            new Thread(() => {
                for (var i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine($"Thread A: {_field}");
                }
            }).Start();

            new Thread(() => {
                for (var i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine($"Thread B: {_field}");
                }
            }).Start();

            new Thread(() =>
            {
                for (var i = 0; i < 5; i++)
                {
                    _field++;
                    Console.WriteLine($"Thread C: {_field}");
                }
            }).Start();

            Console.ReadKey();
        }
    }

}
