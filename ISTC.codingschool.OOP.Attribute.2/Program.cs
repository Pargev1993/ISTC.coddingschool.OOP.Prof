using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class Motorcycle
    {
        [Conditional("Use")]
        public void UseMotorcycle()
        {
            Console.WriteLine("available");
        }

        [Conditional("NoUse")]
        public void NoUseMotorcycle()
        {
            Console.WriteLine("Not available");
        }
    }

    class Program
    {
        static void Main()
        {
            Motorcycle moto = new Motorcycle();
            moto.UseMotorcycle();
            moto.NoUseMotorcycle();
            Console.ReadLine();
        }
    }
}
