using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Example1_20UsingConfigureAwait
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        //an example of a button event handler in a wpf applicatiom that downloads
        //the website and then puts the result in a label
        
        private async void Button_Click(object sender, RoutedEventArgs e) {
            HttpClient client = new HttpClient();

            string content = await client
                .GetStringAsync("http://www.microsoft.com")
                //not execute on the UI thread because this is set to false
                .ConfigureAwait(false);

            Output.Content = content;
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
