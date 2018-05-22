using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("\nCHECKED output value is: {0}",
                         OverflowTest.CheckedMethod());
            Console.WriteLine("UNCHECKED output value is: {0}",
                              OverflowTest.UncheckedMethod());
        }

        public class Account
        {
            public int Cents { get; set; }
            public int Dollars { get; set; }

            public void Deposit(int dollars, int cents) {
                int extraCents = 10;
                int totalCents = cents + Cents;
                int extraDollars = totalCents / 100;
                Cents = totalCents - 100 * extraCents;

                //The checked keyword ensures an overflow exception is thrown when performing
                //the operation
                Dollars += checked(dollars + extraDollars); 
            }
        }

        //Microsoft example from docs

        public static class OverflowTest {

            //Set maxIntValue to the max for integers
            static int maxIntValue = 2147483647;

            //Using a checked expression
            public static int CheckedMethod() {
                int z = 0;

                try
                {
                    //The following line raise an exception because it is checked
                    z = checked(maxIntValue + 10);
                }
                catch (OverflowException e)
                {
                    //displays info about the error
                    Console.WriteLine("CHECKED and CAUGHT: " + e.ToString());
                }

                //value of Z is still 0.
                return z;
            }

            public static int UncheckedMethod() {
                int z = 0;

                try
                {
                    //calculation is unchecked and will not raise an exception
                    z = maxIntValue + 10;
                }
                catch (OverflowException e)
                {
                    //therefore this line is not executed
                    Console.WriteLine("UNCHECKED and CAUGHT: " + e.ToString());
                }

                //Because of the undetected overflow exception, the sum of 214783647 + 10 is -214783639
                return z;
            }
        }
    }
}
