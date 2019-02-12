using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_17
{
    class Program
    {public static int arrayChange(int[] inputArray)
        {
            int total = 0;
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i - 1] < inputArray[i])
                    continue;

                total += inputArray[i - 1] + 1 - inputArray[i];
                inputArray[i] = inputArray[i - 1] + 1;
            }

            return total;

        }
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 3, 5, 5, 5, 4, 12, 12, 10, 15 };
            arrayChange(array);
        }
    }
}
