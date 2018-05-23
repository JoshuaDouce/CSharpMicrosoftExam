using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Question15_1
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        //async specifies an asynchronous method
        public async void GetData(WebResponse response)
        {
            string urlText;

            var sr = new StreamReader(response.GetResponseStream());

            //wait for the operation to complete
            //ReadToEndAsync returns the entire response
            urlText = await sr.ReadToEndAsync();
        }
    }
}
