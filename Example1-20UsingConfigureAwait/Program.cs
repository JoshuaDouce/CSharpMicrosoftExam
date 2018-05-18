using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Example1_20UsingConfigureAwait
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }

        //an example of a button event handler in a wpf applicatiom that downloads
        //the website and then puts the result in a label
        
        //This example throws an exception.
        private async void Button_Click(object sender, RoutedEventArgs e) {
            //Intialize a new http client
            var client = new HttpClient();

            //client retrieves content
            var content = await client
                .GetStringAsync("http://www.microsoft.com")
                //not executed on the UI thread because this is set to false
                .ConfigureAwait(false);

            //This line is not executed on the UI thread because of the ConfigureAwait false, therefore
            //throwing an exception
            Output.Content = content;
        }

        //These are just hear to remove errors not relevant to the example
        public class RoutedEventArgs
        {
        }

        private static class Output
        {
            public static object Content;
        }
    }
}
