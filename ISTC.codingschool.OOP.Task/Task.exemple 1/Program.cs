using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Task.exemple_1
{
    class Program
    {
        static string GetDataFromURL(object Url)
        {
            Thread.Sleep(2000);
            // Create a request for the URL.   
            WebRequest request = WebRequest.Create((Url as string));
            // If required by the server, set the credentials.  
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.  
            WebResponse response = request.GetResponse();
            // Display the status.  
            // Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.  
            Stream dataStream = response.GetResponseStream();
            Console.WriteLine(dataStream);
            // Open the stream using a StreamReader for easy access.  
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.  
            string responseFromServer = reader.ReadToEnd();
            // Return the content.  
            return responseFromServer;
        }
        static void Main(string[] args)
        {

            string Url = " https://jsonplaceholder.typicode.com/comments";
            Func<object, string> func = new Func<object, string>(GetDataFromURL);
            Task<string> Name = new Task<string>(func, Url);
            Name.Start();

           


            while (!Name.IsCompleted)
            {
                Console.ForegroundColor = (ConsoleColor)new Random().Next(1, 15);
                Console.Write("Loading");
                for (int i = 0; i < 8; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(200);
                }
                Console.Clear();
            }

        }
    }
}
