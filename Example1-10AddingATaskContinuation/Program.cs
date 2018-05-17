using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_10AddingATaskContinuation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Starts a task that returns 42
            var t = Task.Run(() =>
            {
                return 42;
                //continue this task and take the result of the previous task and multiply it by 2
            }).ContinueWith((i) => {
                return i.Result * 2;
            }); ;

            Console.WriteLine(t.Result); //Displays 84
        }
    }
}
