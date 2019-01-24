using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SelectionSort
{
    class Program
    {
        public static void InsertShort()
        {
            int[] arr = new int[1000];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 1000);
                Thread.Sleep(10);

            }
            for (int j = 1; j < arr.Length; j++)
            {
                int key = arr[j];
                int s = j - 1;
                while (s >= 0 && arr[s] > key)
                {
                    arr[s + 1] = arr[s];
                    s = s - 1;
                }
                arr[s + 1] = key;
            }
            for (int y = 0; y < arr.Length; y++)
            {
                Console.WriteLine(arr[y]);
            }
        }
        static void Main(string[] args)
        {
            InsertShort();
        }
    }
}
