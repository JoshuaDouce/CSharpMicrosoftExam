using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Example3_10UsingRegex
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static bool ValidatZipCode(string zipcode) {
            Match match = Regex.Match(zipcode, @"^[1-9][0-9]{3}\s?[a-zA-Z]{2}$", RegexOptions.IgnoreCase);
            return match.Success;
        }
    }
}
