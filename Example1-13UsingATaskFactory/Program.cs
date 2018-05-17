using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_13UsingATaskFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var parent = Task.Run(() => {
                var results = new int[3];

                //Create a new task factory that creates a task that attaches to parent with contiuation option of synchronous execution
                var tf = new TaskFactory(TaskCreationOptions.AttachedToParent, TaskContinuationOptions.ExecuteSynchronously);

                //These tasks are created by the task factory using the config specified.
                tf.StartNew(() => results[0] = 0);
                tf.StartNew(() => results[1] = 1);
                tf.StartNew(() => results[2] = 2);

                return results;
            });

            var finalTask = parent.ContinueWith(parentTask => {
                foreach (var item in parentTask.Result)
                {
                    Console.WriteLine(item);
                }
            });

            finalTask.Wait();
        }
    }
}
