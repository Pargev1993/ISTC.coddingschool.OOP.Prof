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
using System.Reflection;

namespace Exemple_2
{

    class Program
    {
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
        public async static Task<string> GetDataFromUrl(string Url)
        {
            try
            {
                return await Task<string>.Factory.StartNew(GetDataFromURL, Url);
            }
            catch (AggregateException ae)
            {

                throw new AggregateException(ae.Message);
            }

        }
        public async static Task<string> GetJsonConvert(string Url)
        {
            


            File.WriteAllText("person.json", Url);
            return await Task<string>.Factory.StartNew(GetDataFromURL, Url);
        }
        static void Main(string[] args)
        {
            string Url ="https://www.itjobs.am/api/v1.0/companies";
            Task<string> task = null;
            task = GetJsonConvert(Url);
            
            

        }
    }
}