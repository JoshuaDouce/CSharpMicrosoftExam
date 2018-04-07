using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_8StartingATask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates a new task and immediately starts it.
            Task t = Task.Run(() => {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine('*');
                }
            });

            //waits until the task is finished before closing
            t.Wait();
        }
    }
}
