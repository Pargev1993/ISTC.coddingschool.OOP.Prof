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




        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter User Name");
            string s = Console.ReadLine();
            string Url = $"https://api.github.com/users/{s}";
            Task<string> task = null;

            try
            {
                task = GetDataFromUrl(Url);
                while (!task.IsCompleted)
                {
                    Console.ForegroundColor = (ConsoleColor)new Random().Next(1, 15);
                    Console.Write("Loading");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(200);
                    }
                    Console.Clear();
                    Console.WriteLine("Opertion Complated!!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                GitHubUser GitHubUsers = JsonConvert.DeserializeObject<GitHubUser>(task.Result);
                GitHubUsers.CallGithubUzer();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            string folowersUrl = $" https://api.github.com/users/{s}/followers";
            Task<string> vs = GetDataFromUrl(folowersUrl);
            Console.WriteLine("If You Want to see Aboute All Folowears Press Any Key!");
            Console.ReadLine();
            FolowerUsers folowerUsers = new FolowerUsers();
            FolowerUsers[] folowerU = JsonConvert.DeserializeObject<FolowerUsers[]>(vs.Result);
            foreach (var item in folowerU)
            {
                item.CallfolowUser();

                Console.WriteLine(new string('*', 50));
                Console.WriteLine("Fore Else Press Any Key");
                Console.ReadLine();
            }


            ///Task<string> d = Method(Url);
            //d.Wait();
            //GitHubUser gitHubUser = new GitHubUser();
            // gitHubUser.CallGithubUzer();


            //Type type = typeof(GitHubUser);
            //FieldInfo[] fileInfo = type.GetFields(BindingFlags.GetField);
            //foreach (var item in fileInfo)
            //{
            //    Console.WriteLine(item.Name);
            //}





            Console.ReadLine();




        }
    }
}
