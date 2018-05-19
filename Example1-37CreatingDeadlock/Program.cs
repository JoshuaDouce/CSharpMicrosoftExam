using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Example1_37CreatingDeadlock
{
    class Program
    {
        //This example result sin deadlock because the lockas are take in reverse order.
        //You can avoid deadlock by making sure locks are taking in the same order

        static void Main(string[] args)
        {
            //Create 2 lock objects
            object lockA = new object();
            object lockB = new object();

            var up = Task.Run(() => {
                //Checks lock A
                lock (lockA)
                {
                    //Sleeps
                    Thread.Sleep(1000);
                    //Tries to lock B
                    lock (lockB)
                    {
                        Console.WriteLine("Locked A and B");
                    }
                }
            });

            lock (lockB)
            {
                lock (lockA)
                {
                    Console.WriteLine("Locked B and A");
                }
            }

            up.Wait();
        }
    }
}
