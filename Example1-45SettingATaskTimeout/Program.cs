using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example1_45SettingATaskTimeout
{
    class Program
    {

        static void Main(string[] args)
        {
            Task longRunning = Task.Run(() => {
                Thread.Sleep(10000);
            });

            //Use waitAny overload method to specify a timeout
            //will return -1 if the task timed out
            int index = Task.WaitAny(new[] { longRunning }, 1000);

            if (index == -1)
            {
                Console.WriteLine("Task timed out");
            }
        }
    }
}
