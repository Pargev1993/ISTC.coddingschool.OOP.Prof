using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using HtmlAgilityPack;
using OpenQA.Selenium.Chrome;

namespace Staff.am_Project
{
    class GetContent
    {
        public static List<Company> GetContentMethod(string CompanyUrl)
        {

            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlDocument htmlDocument = htmlWeb.Load(CompanyUrl);
            string Path = "//div[@class='company-action company_inner_right']";
            HtmlNodeCollection htmlNodes = htmlDocument.DocumentNode.SelectNodes(Path);
            List<string> companyUrl = new List<string>();
            foreach (var Htmlnode in htmlNodes)
            {
                try
                {
                    string href = Htmlnode.InnerHtml;
                    var splited = href.Split(' ')[1];
                    var urlcomp = splited.Substring(6, splited.Length - 7);
                    companyUrl.Add(@"https://staff.am" + urlcomp);
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message) ;
                }

            }
            List<Company> companies = new List<Company>();

            foreach (var Urls in companyUrl)
            {
                HtmlDocument document = htmlWeb.Load(Urls);
                string jobPath = "//p[@class='professional-skills-description']";
                HtmlNodeCollection htmlNode = document.DocumentNode.SelectNodes(jobPath);

                string companyProp = "//div[@class='col-lg-8 col-md-8 about-text']";
                HtmlNodeCollection htmlNodesAboutComp = document.DocumentNode.SelectNodes(companyProp);
                string aboutText = htmlNodesAboutComp[0].InnerText.Replace("\n", "");

                string companyName = "//h1[@class=\"text-left\"]";
                HtmlNodeCollection htmlNodeOfName = document.DocumentNode.SelectNodes(companyName);
               
                Company company = new Company();
                try
                {
                    company.Name = htmlNodeOfName[0].InnerText;
                    company.Industry = htmlNode[0].InnerText;
                    company.Type = htmlNode[1].InnerText;
                    company.NumberOfEmployes = htmlNode[2].InnerText;
                    company.Data = htmlNode[3].InnerText;
                    company.WebSite = htmlNode[4].InnerText;
                    company.Adress = htmlNode[5].InnerText;
                    company.AboutCompany = aboutText;
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
                companies.Add(company);
                company.Print();
                Thread.Sleep(5000);
                Console.Clear();
            }

            return companies;


        }



    }
}
