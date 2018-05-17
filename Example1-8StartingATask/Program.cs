using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_8StartingATask
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Creates a new task and immediately starts it.
            var t = Task.Run(() => {
                for (var i = 0; i < 100; i++)
                {
                    Console.WriteLine('*');
                }
            });

            var t2 = Task.Run(() =>
            {
                for (var i = 0; i < 100; i++)
                {
                    Console.WriteLine("Hello");
                }
            });

            //waits until the task is finished before closing
            t.Wait();
            t2.Wait();
        }
    }
}
