using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Example1_19ScalabilityVSResponsiveness
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }

        //Uses thread from a threadpool while sleeping
        public Task SleepAsyncA(int millisecondTimeout) {
            return Task.Run(() => Thread.Sleep(millisecondTimeout));
        }

        //Does not occupy a thread while waiting for the timer to run. Giving you scalability
        public Task SleepAsyncB(int millisecondTimeout) {
            //Create new task completion source
            TaskCompletionSource<bool> tcs = null;

            //Create a new timer object
            var t = new Timer(delegate { tcs.TrySetResult(true); }, null, -1, -1);

            //Checks if task is completed
            tcs = new TaskCompletionSource<bool>(t);

            //reduce the timeout
            t.Change(millisecondTimeout, -1);

            //Return the task created by the completion source
            return tcs.Task;
        }
    }
}
