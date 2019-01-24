using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoubleSort
{
    class Program
    {

        static void Main(string[] args)
        {
            BoubleSort();

          
        }
        
        public static void BoubleSort()
        {
            Random random = new Random();

            int[] array = new int[1000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 1000);
            }
           

            bool C;
            do
            {
                C = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(ref array[i], ref array[i + 1]);
                        C = true;
                    }

                }
            } while (C);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }

        public static void Swap(ref int x, ref int y)
        {
            int c = x;
            x = y;
            y = c;
        }
    }
}
