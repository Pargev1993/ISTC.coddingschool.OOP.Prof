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
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string CompanyUrl = "https://staff.am/en/companies";

            List<Company> companies= GetContent.GetContentMethod(CompanyUrl);
            Console.ReadKey();
        }
    }
}