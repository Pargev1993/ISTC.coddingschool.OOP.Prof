using HtmlAgilityPack;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Staff.am_Project
{
    class CallChromeDriver
    {
        public static string CallChrome(string CompanyUrl)
        {
            string PatheForChrome = @"C:\Users\pqoal\source\repos\ISTC.coddingschool.OOP.Prof\ISTC.codingschool.OOP.Staff.am\Staff.am Project\bin\Debug";

            ChromeOptions co = new ChromeOptions();

            co.AddArgument("--disable-images");

            ChromeDriver chromeDriver = new ChromeDriver(PatheForChrome, co);
            chromeDriver.Navigate().GoToUrl(CompanyUrl);

            for (int i = 0; i < 2; i++)

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
            chromeDriver.Close();
            return htmldoc.Text;
        }
    }
}
