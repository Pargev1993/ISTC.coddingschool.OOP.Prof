using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[20];
            num.GetArrayNumbers();

            int s = 2;
            var Res= num.GetDigitNumbersFromArray(s) ;
        }
    }
}
