using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_39PotentialIssueWhenMultithreading
{
    class Program
    {
        //Normally you would expect this to output 5 or nothing.
        //However in a multithreaded environment you could get a _flag = 1 and _value = 0;
        //This would happen if thread one changed _flag = 1, at this point thread 2 execites before
        //thread 1 can change the value.
        private static int _flag;
        private static int _value;

        static void Main(string[] args)
        {
        }

        public static void Thread1() {
            _value = 5;
            _flag = 1;
        }

        public static void Thread2() {
            if (_flag == 1)
            {
                Console.WriteLine(_value);
            }
        }
    }
}
