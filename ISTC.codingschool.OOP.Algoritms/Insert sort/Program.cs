using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Insert_sort
{
    class Program
    {
       
     public static   void insertionSort()
        {
            int n = 1000;
            int[] arr = new int[1000];
            for (int l = 0; l < arr.Length; l++)
            {
                arr[l] = new Random().Next(1, 1000);
                Thread.Sleep(10);
                
            }
            
            for (int  i = 1; i < n; i++)
            {
               int key = arr[i];
               int j = i - 1;

               
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            for (int k = 0; k < arr.Length; k++)
            {
                Console.WriteLine(arr[k]);
            }
        }
        static void Main(string[] args)
        {

            insertionSort();
        }
    }
}
