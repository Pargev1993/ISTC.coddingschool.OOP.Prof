using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff.am_Project
{
    class Company
    {
        public string Name { get; set; }
        public string Industry { get; set; }
        public string Adress { get; set; }
        public string Data { get; set; }
        public string WebSite { get; set; }
        public string AboutCompany { get; set; }
        public string Type { get; set; }
        public string NumberOfEmployes { get; set; }
        public Company()
        {

        }
        public void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Industry);
            Console.WriteLine(Type);
            Console.WriteLine(NumberOfEmployes);
            Console.WriteLine(Data);
            Console.WriteLine(WebSite);
            Console.WriteLine(Adress + "\n");
            Console.WriteLine(AboutCompany);
        }

    }
}
