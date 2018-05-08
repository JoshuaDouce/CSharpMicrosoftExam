using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Example3_11CollapsingMultipleWhiteSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexOptions opts = RegexOptions.None;
            Regex regex = new Regex(@"[ ]{2,}", opts);

            string input = "1 2 3    4 5";
            string result = regex.Replace(input, " ");

            Console.WriteLine(result);
        }
    }
}
