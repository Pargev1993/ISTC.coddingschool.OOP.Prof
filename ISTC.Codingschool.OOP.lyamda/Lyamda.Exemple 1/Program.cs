using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyamda.Exemple_1
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 556, 8, 98 };

            var b = array.Where(d => d % 2 == 0).Where(d => d != 0).ToList();
  
        }
    }
}
