using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Example1_19ScalabilityVSResponsiveness
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        //Uses thread from a threadpool while sleeping
        public Task SleepAsyncA(int millisecondTimeout) {
            return Task.Run(() => Thread.Sleep(millisecondTimeout));
        }

        //Does not occupy a thread while waiting for the timer to run. Giving you scalability
        public Task SleepAsyncB(int millisecondTimeout) {
            TaskCompletionSource<bool> tcs = null;
            var t = new Timer(delegate { tcs.TrySetResult(true); }, null, -1, -1);
            tcs = new TaskCompletionSource<bool>(t);
            t.Change(millisecondTimeout, -1);
            return tcs.Task;
        }
    }
}
