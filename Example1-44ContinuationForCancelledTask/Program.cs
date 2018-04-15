using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Example1_44ContinuationForCancelledTask
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Task task = Task.Run(() => {
                while (!token.IsCancellationRequested)
                {
                    Console.Write("*");
                    Thread.Sleep(1000);
                }

                throw new OperationCanceledException();
            }, token).ContinueWith((t) => {
                t.Exception.Handle((e) => true);
                Console.WriteLine("You have cancelled the task");
            }, TaskContinuationOptions.OnlyOnCanceled);
        }
    }
}
