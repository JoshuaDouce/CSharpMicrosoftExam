using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_35AccessingSharedDataOnMultithread
{
    class Program
    {
        //simulates 2 threads accessing the same shared variable simultaneously outputs a different value each time;
        static void Main(string[] args)
        {
            int n = 0;

            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    n++;
                }
            });

            for (int i = 0; i < 1000000; i++)
            {
                n--;
            }

            up.Wait();
            Console.WriteLine(n);

        }
    }
}
