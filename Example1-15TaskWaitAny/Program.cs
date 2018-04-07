using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Example1_15TaskWaitAny
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create array of tasks that retirn an int of size 3
            Task<int>[] tasks = new Task<int>[3];

            tasks[0] = Task.Run(() => {
                Thread.Sleep(2000);
                return 1;
            });
            tasks[1] = Task.Run(() => {
                Thread.Sleep(1000);
                return 2;
            });
            tasks[2] = Task.Run(() => {
                Thread.Sleep(3000);
                return 3;
            });

            while (tasks.Length > 0)
            {
                //when task is completed
                int i = Task.WaitAny(tasks);
                Task<int> completedTask = tasks[i];

                //write result
                Console.WriteLine(completedTask.Result);

                //remove from tasks array
                var temp = tasks.ToList();
                temp.RemoveAt(i);
                tasks = temp.ToArray();
            }
        }
    }
}
