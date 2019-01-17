﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;

namespace Exemple_2
{

    public class GitHubUser
    {
        public string login { get; set; }
        public int id { get; set; }
        public string node_id { get; set; }
        public string avatar_url { get; set; }
        public string gravatar_id { get; set; }
        public string url { get; set; }
        public string html_url { get; set; }
        public string followers_url { get; set; }
        public string following_url { get; set; }
        public string gists_url { get; set; }
        public string starred_url { get; set; }
        public string subscriptions_url { get; set; }
        public string organizations_url { get; set; }
        public string repos_url { get; set; }
        public string events_url { get; set; }
        public string received_events_url { get; set; }
        public string type { get; set; }
        public bool site_admin { get; set; }
        public string name { get; set; }
        public object company { get; set; }
        public string blog { get; set; }
        public string location { get; set; }
        public object email { get; set; }
        public object hireable { get; set; }
        public string bio { get; set; }
        public int public_repos { get; set; }
        public int public_gists { get; set; }
        public int followers { get; set; }
        public int following { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }

    class Program
    {
        static string GetDataFromURL(object url)
        {
            var webRequest = WebRequest.Create(url as string) as HttpWebRequest;

            webRequest.ContentType = "application/json";
            webRequest.UserAgent = "Nothing";

            using (var s = webRequest.GetResponse().GetResponseStream())
            {


                using (var sr = new StreamReader(s))
                {
                    var contributorsAsJson = sr.ReadToEnd();
                    return contributorsAsJson;
                }
            }

        }
        public async static Task<string> GetJsonConvert(string Url)
        {
            //Task<string> task = new Task<string>(GetDataFromURL, Url);
            //task.Start();
            //await task;
            return await Task<string>.Factory.StartNew(GetDataFromURL, Url);


            //GitHubUser  rootobject = JsonConvert.DeserializeObject<GitHubUser>(Url);
            //Console.WriteLine(rootobject.blog);
            // //Console.WriteLine(d);
            //File.WriteAllText("person.json", Url);
        }

      

        static void Main(string[] args)
        {
            string Url = "https://api.github.com/users/Pargev1993";
            var d = GetDataFromURL(Url);
            Task<string> s = GetJsonConvert(Url);


            s.Wait();
            Console.WriteLine(s.Result);
            ///Task<string> d = Method(Url);
            //d.Wait();
            GitHubUser gitHubUser = new GitHubUser();
            

            Console.ReadLine();




        }
    }
}
