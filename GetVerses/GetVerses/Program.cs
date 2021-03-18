using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace GetVerses
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        public static async void GetVerse()
        {
            string baseUrl = "https://emfservicesstage-api.azure-api.net/bible/v1/getversesbydate?siteId=1";
            try
            {
                using(HttpClient client = new HttpClient())
                {
                    using(HttpResponseMessage responseMessage = new HttpResponseMessage())
                    {
                        using(HttpContent content = responseMessage.Content)
                        {
                            string data = await content.ReadAsStringAsync();
                            if(data != null)
                            {
                                var dataObj = JObject.Parse(data);


                                Console.WriteLine("data------------{0}", JObject.Parse(data)["results"]);
                            }
                            else
                            {
                                Console.WriteLine("No data");
                            }    
                        }
                    }
                }

            }
            catch(Exception exception)
            {
                Console.WriteLine("Exception Hit------------");
                Console.WriteLine(exception);
            }
        }
    }
}
