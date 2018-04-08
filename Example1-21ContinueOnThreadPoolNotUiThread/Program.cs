using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Example1_21ContinueOnThreadPoolNotUiThread
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        //Both await methods use the ConfigureAwait(false) because if the first method is already finished
        //before the awaiter checks the code still runs on ui thread
        private async void Button_Click(object sender, RoutedEventArgs e) {
            HttpClient client = new HttpClient();

            string content = await client
                .GetStringAsync("http://www.microsoft.com")
                .ConfigureAwait(false);

            using (FileStream sourceStream = new FileStream("temp.html",
                FileMode.Create, FileAccess.Write, FileShare.None, 4096, useAsync: true)) {
                byte[] encodedText = Encoding.Unicode.GetBytes(content);
                await sourceStream.WriteAsync(encodedText, 0, encodedText.Length)
                    .ConfigureAwait(false);
            };
        }

        //These are just hear to remove errors not relevant to the example
        private class RoutedEventArgs
        {
        }

        private static class Output
        {
            public static object Content;
        }
    }
}
