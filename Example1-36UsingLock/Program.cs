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
            
            //creates a new lock object. By checking this lock objetc you can synchronize access to the variable.
            Object _lock = new Object();

            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    //checks the if access to the variable is locked, if not will lock and then access the variable
                    lock (_lock) {
                        n++;
                    }
                    
                }
            });

            for (int i = 0; i < 1000000; i++)
            {
                //checks the if access to the variable is locked, if not will lock and then access the variable
                lock (_lock) {
                    n--;
                }
                
            }

            up.Wait();
            Console.WriteLine(n);

            //However this solution can lead to th threads being blocked and even cause a deadlock. 
            //Deadlock - A sistuation where both threads are awaiting on eachother so never complete.
        }
    }
}
