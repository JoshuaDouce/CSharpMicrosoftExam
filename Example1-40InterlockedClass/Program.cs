using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Example1_40InterlockedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            var up = Task.Run(() => {
                for (int i = 0; i < 1000000; i++)
                {
                    //Improving on example 1-35, Using Tthe interlocked class makes this operation atomic.
                    //Interlock is only useful for adding and subtracting, for more complex ops you still 
                    //need to use lock.
                    Interlocked.Increment(ref n);
                }
            });

            for (int i = 0; i < 1000000; i++)
            {
                Interlocked.Decrement(ref n);
            }

            up.Wait();
            Console.WriteLine(n);
        }
    }
}
