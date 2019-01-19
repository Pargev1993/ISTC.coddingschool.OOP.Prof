using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary.exemple
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<int, string>()
            {
                { 12,"Pargev" },
                { 15,"Heno" }
            };
            var castomor = dictionary[12];
            dictionary.Remove(12);

            Console.WriteLine(castomor);

           
        }
    }
}
