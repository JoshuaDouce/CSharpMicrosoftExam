using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_32ConcurrentStack
{
    internal class Program
    {
        //The stack is LIFO collection. (Last In First Out)
        private static void Main(string[] args)
        {
            var stack = new ConcurrentStack<int>();

            //pushes an item onto the stack
            stack.Push(42);
            stack.Push(41);

            //pop removes the most recent item added to the stack
            if(stack.TryPop(out var result))
                Console.WriteLine($"Popped: {result}");

            //pushes a range of items onto the stack;
            stack.PushRange(new[] { 1, 2, 3 });

            var values = new int[2];

            //removes a range of values from the stack
            stack.TryPopRange(values);

            foreach (var i in values)
            {
                Console.WriteLine(i);
            }

        }
    }
}
