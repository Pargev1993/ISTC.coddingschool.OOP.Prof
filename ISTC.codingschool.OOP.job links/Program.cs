using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;
using ISTC.codingschool.OOP.job_links;

namespace Exemple_2
{
    class Program
    {
        public static void Print(List<Jobs> companies)
        {
            Parallel.ForEach(companies, (company) =>
            {
                Console.WriteLine($"Company Name:{company.Name},Id:{company.Id}\n");

            });
        }

        public static async void Run(string url, CancellationToken cToken)
        {
            try
            {
                string result = await Task.Run(() => Call.GetDataAsync(url, cToken));
                List<Jobs> companies = null;

                await Task.Run(() =>
                {
                    if (cToken.IsCancellationRequested)
                    {
                        Console.WriteLine("Operation Aborted");
                        return;
                    }
                    companies = JsonConvert.DeserializeObject<List<Jobs>>(result);
                });

                Print(companies);
            }
            catch (ArgumentNullException arg) { Console.WriteLine(arg.Message); }
            catch (Exception e) { Console.WriteLine(e.Message); }


        }

        static void Main(string[] args)
        {
            string url = "https://www.itjobs.am/api/v1.0/companies";
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;

            try
            {
                Run(url, token);
                Console.WriteLine("Input 'c' for Abort");
                if (Console.ReadKey().KeyChar == 'c')
                    tokenSource.Cancel();
            }
            catch (Exception e) { Console.WriteLine(e.Message); }



            Console.ReadLine();
        }
        static string GetDataFromURL(object url)
        {
            try
            {
                var webRequest = WebRequest.Create(url as string) as HttpWebRequest;

                webRequest.ContentType = "application/json";
                webRequest.UserAgent = "Nothing";

                using (var s = webRequest.GetResponse().GetResponseStream())
                {
                    Thread.Sleep(1000);

                    using (var sr = new StreamReader(s))
                    {
                        var contributorsAsJson = sr.ReadToEnd();
                        return contributorsAsJson;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }


        }
    }
}