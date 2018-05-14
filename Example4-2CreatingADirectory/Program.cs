using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4_2CreatingADirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            var directory = Directory.CreateDirectory(@"C:\Temp\ProgrammingInCSharp\NewDirectory");

            var directoryInfo = new DirectoryInfo(@"C:\Temp\ProgrammingInCSharp\DirectoryInfo");
            directoryInfo.Create();
        }
    }
}
