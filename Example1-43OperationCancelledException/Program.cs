using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Example1_43OperationCancelledException
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new cancelltion token source
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            //use source to create a new token
            CancellationToken token = cancellationTokenSource.Token;

            //Execute a new thread using overload that takes a token
            Task task = Task.Run(() => {
                while (!token.IsCancellationRequested)
                {
                    Console.Write("*");
                    Thread.Sleep(100);
                }

                //If task is cancelled thrown an exception. A task will throw an aggregate exception.
                token.ThrowIfCancellationRequested();
            }, token);

            try
            {
                Console.WriteLine("Press enter to stop the task");
                Console.ReadLine();

                cancellationTokenSource.Cancel();
                task.Wait();
            }
            //catch the aggregate exception
            catch (AggregateException e)
            {
                //Write the message from the first exception to the console
                Console.WriteLine(e.InnerExceptions[0].Message);
            }

            Console.WriteLine("Press enter to stop the application");
            Console.ReadLine();
        }
    }
}
