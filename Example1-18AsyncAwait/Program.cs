using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace Example1_18AsyncAwait
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //accesss result on main thread which blocks teh code until the async method completes
            var result = DownloadContent().Result;
            Console.WriteLine(result);
        }

        //Method needs to be decorated with async dignature to ensure the mehod is asynchronous
        public static async Task<string> DownloadContent() {
            //the using statement ensures IDisposable is called when the function is complete
            using (var client = new HttpClient()) {
                //GetStringAsync uses asynchronous code internally and returns Task<string>
                var result = await client.GetStringAsync("http://www.microsoft.com");
                return result;
            }
        }
    }
}
