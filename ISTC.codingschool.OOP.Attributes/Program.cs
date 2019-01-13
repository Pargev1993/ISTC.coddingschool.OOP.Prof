using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Newtonsoft.Json;


namespace ISTC.codingschool.OOP.Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(User);
            object [] attrs = type.GetCustomAttributes(false);
            foreach (AttInfo item in attrs)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Code);
            }
        }
    }
}
