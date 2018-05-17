using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example1_14TaskWaitAll
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Create an array of tasks
            var tasks = new Task[3];

            //Start each task
            tasks[0] = Task.Run(() => {
                Thread.Sleep(1000);
                Console.WriteLine("1");
                return 1;
            });

            tasks[1] = Task.Run(() => {
                Thread.Sleep(1000);
                Console.WriteLine("2");
                return 2;
            });

            tasks[2] = Task.Run(() => {
                Thread.Sleep(1000);
                Console.WriteLine("3");
                return 3;
            });

            //Using wait all executes the tasks asynchronousy therefore only taking 1000ms and 3000ms if 
            //executed synchronously
            Task.WaitAll(tasks);
        }
    }
}
