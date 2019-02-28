using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Exemple_1
{
    static class OperationWithArray
    {
        public static void GetPairsNumbers( ref int [] num)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                    res.Add(num[i]);
            }
            foreach (var OddNum in res)
            {
                Console.WriteLine($"Pairs Numbers are: {OddNum}" );
            }
            Console.WriteLine(new string('*',30));
        }
        public static void GetOddNumbers(ref int[] num)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 != 0)
                    res.Add(num[i]);
            }
            foreach (var OddNum in res)
            {
                Console.WriteLine($"Odd Numbers are: {OddNum}");
            }
            Console.WriteLine(new string('*', 30));
        }
      
    }
}
