using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example1_38GenratedCodeFromALockStatement
{
    class Program
    {
        static object gate = new Object();

        //Specifies if the lock is taken
        static bool _lockTaken = false;

        static void Main(string[] args)
        {
            try
            {
                //try to enter the gate and take the lock
                Monitor.Enter(gate, ref _lockTaken);
            }
            finally {
                //if lock is taken exit the gate
                if (_lockTaken)
                {
                    Monitor.Exit(gate);
                }
            }
        }


    }
}
