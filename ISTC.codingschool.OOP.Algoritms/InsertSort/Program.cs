using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace InsertSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] =rand.Next(0, 10);
                //Thread.Sleep(20);
            }

            for (int j = 1; j <arr.Length; j++)
            {
                int T = arr[j];
                int k = j - 1;
                while (k>=0&&arr[k]>T)
                {
                    arr[k + 1] = arr[k];
                    k--;
                }
                arr[k + 1] = T;

            }
            for (int r = 0; r < arr.Length; r++)
            {
                Console.WriteLine(arr[r]);
            }
        }
        
    }
}
