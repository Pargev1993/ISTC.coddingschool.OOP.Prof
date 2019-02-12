using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_19
{
    class Program
    {
        public static int arrayMaximalAdjacentDifference(int[] inputArray)
        {
            int c = 0;
            for (int i = 1; i < inputArray.Length ; i++)
            {
                if (inputArray[i] > inputArray[i - 1] && i <= inputArray.Length - 2)
                {
                   
                        if (inputArray[i + 1] > inputArray[i - 1])
                            c = Math.Abs( inputArray[i] - inputArray[i - 1]);
                        else
                            c =Math.Abs( inputArray[i] - inputArray[i + 1]);
                    
                  
                }
                else
                    c =Math.Abs( inputArray[i] - inputArray[i - 1]);


            }
            return c;
        }
        static void Main(string[] args)
        {
            int[] a = { 10, 11, 13 };
            arrayMaximalAdjacentDifference(a);
        }
    }
}
