using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Reflection;
using HtmlAgilityPack;
using OpenQA.Selenium.Chrome;

namespace Staff.am_Project
{
    class Program
    {
        static void Main(string[] args)
        {

            //string Url = "https://staff.am/en/companies?CompaniesFilter%5BkeyWord%5D=&CompaniesFilter%5Bindustries%5D=&CompaniesFilter%5Bindustries%5D%5B%5D=2&CompaniesFilter%5Bemployees_number%5D=&CompaniesFilter%5Bsort_by%5D=&CompaniesFilter%5Bhas_job%5D=";
            string Url = "https://staff.am/en/jobs";
            HtmlWeb htmlWeb = new HtmlWeb();


            string PatheForChrome = @"C:\Users\pqoal\source\repos\ISTC.coddingschool.OOP.Prof\ISTC.codingschool.OOP.Staff.am\Staff.am Project\bin\Debug";
            ChromeOptions co = new ChromeOptions();
            co.AddArgument("--disable-images");
            ChromeDriver chromeDriver = new ChromeDriver(PatheForChrome, co);

            chromeDriver.Navigate().GoToUrl(Url);
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    chromeDriver.ExecuteScript($"window.scrollBy(0,1750);");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Thread.Sleep(2000);
            }
            var htmldoc = new HtmlDocument();
            htmldoc.LoadHtml(chromeDriver.PageSource);

            string path = "//div[@class=\"job-inner job-item-title\"]";
            var nodecollection = htmldoc.DocumentNode.SelectNodes(path);
            foreach (var item in nodecollection)
            {
                Console.WriteLine(item.InnerText);
                // Console.WriteLine(item.InnerHtml);
            }
            Console.ReadKey();
        }
    }
}