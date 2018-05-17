using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_17UsingParallelBreak
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var result = Parallel.
                For(0, 1000, (int i, ParallelLoopState loopState) => {
                    if (i != 500) return;
                    Console.WriteLine("Breaking Loop");
                    //Break ensures all iterations that are currently running will be finished
                    loopState.Break();
                });

            var result2 = Parallel.
                For(0, 1000, (int i, ParallelLoopState loopState) => {
                    if (i != 500) return;
                    Console.WriteLine("Stopping Loop");
                    //Stop terminates everything
                    loopState.Stop();
                });
        }
    }
}
