using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_36UsingLock
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 0;

            Object _lock = new Object();

            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    lock (_lock) {
                        n++;
                    }
                    
                }
            });

            for (int i = 0; i < 1000000; i++)
            {
                lock (_lock) {
                    n--;
                }
                
            }

            up.Wait();
            Console.WriteLine(n);
        }
    }
}
