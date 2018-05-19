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
            //Create a new CTS 
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            //Create ne token from CTS
            CancellationToken token = cancellationTokenSource.Token;

            Task task = Task.Run(() => {
                while (!token.IsCancellationRequested)
                {
                    Console.Write("*");
                    Thread.Sleep(1000);
                }

                //Throw cancellation exception
                throw new OperationCanceledException();
                //Continue with spcified action
            }, token).ContinueWith((t) => {
                t.Exception.Handle((e) => true);
                Console.WriteLine("You have cancelled the task");
            }, TaskContinuationOptions.OnlyOnCanceled);
            //Only continue on cancellation
        }
    }
}
