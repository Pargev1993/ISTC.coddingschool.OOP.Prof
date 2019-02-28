using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        public static int countSumOfTwoRepresentations(int n, int l, int r)
        {
            int sum = 0;
            for (int i = l; i <= r; i++)
            {
                for ( int j = i; j <= r;j++)
                {
                    if (i + j == n)
                        sum++;
                }
            }


            return sum;
        }
        static void Main(string[] args)
        {
        
            countSumOfTwoRepresentations(24,12,12);

        }
    }
}
