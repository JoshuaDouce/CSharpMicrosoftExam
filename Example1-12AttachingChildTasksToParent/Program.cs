using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_12AttachingChildTasksToParent
{
    class Program
    {
        static void Main(string[] args)
        {
            //this task finishes when all child tasks have finished
            Task<Int32[]> parent = Task.Run(() => {
                var results = new Int32[3];
                new Task(() => results[0] = 0, TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[1] = 1, TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[2] = 2, TaskCreationOptions.AttachedToParent).Start();
                return results;
            });

            //this task runs only after the parent task has finished
            var finalTask = parent.ContinueWith(
                parentTask =>
                {
                    foreach (var item in parentTask.Result)
                    {
                        Console.WriteLine(item);
                    }
                });

            finalTask.Wait();
        }
    }
}
