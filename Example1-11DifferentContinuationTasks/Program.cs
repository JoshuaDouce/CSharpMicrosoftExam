using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_11DifferentContinuationTasks
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Create a new task that returns 42
            var t = Task.Run(() =>
            {
                //if you uncomment this line console will display faulted
                //throw new Exception();
                return 42;
            });

            //if task is canceled display cancelled
            t.ContinueWith((i) => {
                Console.WriteLine("Canceled");
            }, TaskContinuationOptions.OnlyOnCanceled);

            //if task faults display faulted
            t.ContinueWith((i) => {
                Console.WriteLine("Faulted");
            }, TaskContinuationOptions.OnlyOnFaulted);

            //if ran to completion display completed
            var completedTask = t.ContinueWith((i) => {
                Console.WriteLine("Completed");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();
        }
    }
}
