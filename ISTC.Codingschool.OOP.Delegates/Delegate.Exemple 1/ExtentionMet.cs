using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Exemple_1
{
   static class ExtentionMet
    {
        public static int []  AddNumbers(this int [] x)
        {
            Random random = new Random();
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = random.Next(1, 30);

            }
            return x;
        }
    }
}
