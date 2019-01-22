using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.codingschool.OOP.Attributes._1
{
    [Nature("Winter","White",2019,01)]
    class Program
    {
        static void Main(string[] args)
        {
            GetAttribute(typeof(Program));
        }
        public static void GetAttribute(Type type)
        {
            NatureAttribute natureAttribute;
            natureAttribute = (NatureAttribute)Attribute.GetCustomAttribute(type, typeof(NatureAttribute));
            Console.WriteLine(natureAttribute.Mounth);
            Console.WriteLine(natureAttribute.Season);
            Console.WriteLine(natureAttribute.Year);
            Console.WriteLine(natureAttribute.Color);
            Console.WriteLine(natureAttribute.GetType());
        }
    }
}
