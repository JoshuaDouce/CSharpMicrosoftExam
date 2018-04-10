using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_32ConcurrentStack
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentStack<int> stack = new ConcurrentStack<int>();

            stack.Push(42);

            int result; 

            if(stack.TryPop(out result))
                Console.WriteLine("Popped: {0}", result);

            stack.PushRange(new int[] { 1, 2, 3 });

            int[] values = new int[2];
            stack.TryPopRange(values);

            foreach (var i in values)
            {
                Console.WriteLine(i);
            }

        }
    }
}
