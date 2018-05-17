using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_9TaskReturningValue
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Creates a task and runs it immediately returning the value 42
            var t = Task.Run(() => 42);
            Console.WriteLine(t.Result); //Displays 42
        }
    }
}
