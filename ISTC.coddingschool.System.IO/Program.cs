using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ISTC.coddingschool.System.IO
{
    class Program
    {
        static void Main(string[] args)
        {
            var directroty = new DirectoryInfo(@"C:\Windows\assembly");
            if (directroty.Exists)
            {
                Console.WriteLine(directroty.FullName);
                Console.WriteLine(directroty.Name);
                Console.WriteLine(directroty.Parent);
                Console.WriteLine(directroty.Root);
                Console.WriteLine(directroty.LastAccessTime);
                Console.WriteLine(directroty.Attributes);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
