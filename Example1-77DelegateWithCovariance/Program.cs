using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_77DelegateWithCovariance
{
    class Program
    {
        public delegate TextWriter CovarianceDel();

        public static StreamWriter MethodStream() { return null; }
        public static StreamWriter MethodString() { return null; }

        public static CovarianceDel del;

        static void Main(string[] args)
        {
            //Because MethodStream and MethodString inherit from Text write you can use 
            //del with both methods. This is covariance;
            del = MethodStream;
            del = MethodString;
        }
    }
}
