using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question11_1
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static decimal CalculateInterest(decimal loanAmount, int loanTerm, decimal loanRate)
        {
            decimal interestAmount = loanAmount * loanRate * loanTerm;

            #if DEBUG //if in debug mode execute the following lines
            LogLine("Interest Amount :" , interestAmount.ToString("c"));
            #endif //end section

            return interestAmount;
        }

        public static void LogLine(string message, string detail)
        {
            Console.WriteLine("Log: {0} = {1}", message, detail);
        }
    }
}
