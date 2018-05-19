using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example1_42UsingCancellationToken
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new cancellation token source
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            //use the CTS to create a new token
            CancellationToken token = cancellationTokenSource.Token;

            Task task = Task.Run(() => {
                //check if canellation is requested
                while (!token.IsCancellationRequested)
                {
                    Console.WriteLine('*');
                    Thread.Sleep(1000);
                }
            }, token );//use token overload

            Console.WriteLine("Press enter to stop the task");
            Console.ReadLine();
            //send cancellation request to the token source
            cancellationTokenSource.Cancel();

            Console.WriteLine("Press enter to end the application");
            Console.ReadLine();
        }
    }
}
