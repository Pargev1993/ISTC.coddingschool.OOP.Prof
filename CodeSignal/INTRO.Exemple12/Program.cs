using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTRO.Exemple12
{
    class Program
    {





        public static void Method(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;
        }
        static void Main(string[] args)
        {

            Random random = new Random();
            random.Next(-1, 999);
            int[] a = new int[20];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(-1, 20);
            }

            for (int j = 1; j < a.Length; j++)
            {
                int key = 0;
                if (a[j] != -1)
                {
                    key = a[j];

                    int s = j - 1;
                    while (s >= 0 && a[s] > key)
                    {

                        if (key != -1)
                        {
                            a[s + 1] = a[s];
                            s = s - 1;
                        }
                      
                     
                    }
                    a[s + 1] = key;
                }
            }
            for (int y = 0; y < a.Length; y++)
            {
                Console.WriteLine(a[y]);
            }
        }
    }
}
