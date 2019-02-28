using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_1
{
   static  class AddNumbers
    {
        public static int [] GetArrayNumbers(this int [] a)
        {
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(1, 25);
            }
            return a;
        }

    }
}
