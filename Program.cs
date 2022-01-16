using System;
using System.Text.Json;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace sni
{
    class Program
    {
        private static HttpClient client;

        static void Main(string[] args)
        {
            AsyncMain().Wait();
            Console.WriteLine("Hello World!");
        }

        static async Task AsyncMain()
        {
            if (client == null)
            {
                // ServicePointManager.Expect100Continue = true;
                // ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                client = new HttpClient();
            }

            /** var log = new Object();
            var json = JsonSerializer.Serialize(log);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            **/
            var response = await client.GetAsync(new Uri("https://dev--sni.debug.autocode.gg/"));
            var responseString = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseString);
        }
    }
}