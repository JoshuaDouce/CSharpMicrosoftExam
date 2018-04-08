using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace Example1_18AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            //accesss result on main thread which blocks teh code until the async method completes
            string result = DownloadContent().Result;
            Console.WriteLine(result);
        }

        public static async Task<string> DownloadContent() {
            using (HttpClient client = new HttpClient()) {
                //GetStringAsync uses asynchronous code internally and returns Task<string>
                string result = await client.GetStringAsync("http://www.microsoft.com");
                return result;
            }
        }
    }
}
