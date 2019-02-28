using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_1
{
   static class Get_DigitNumbers
    {
        public static List<int> GetDigitNumbersFromArray(this int [] a,int s)
        {
            List<int> d = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % s == 0)
                    d.Add(a[i]);
                
            }
            return d;
        }
    }
}
