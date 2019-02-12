using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_16
{
    class Program
    {
        public static void Swap(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;
        }
        public static bool areSimilar(int[] a, int[] b)
        {
            bool h = true;
            int y = 0;
            int c = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b[i])
                    continue;
                else
                {
                    y = a[i];
                    c = b[i];
                    Swap(ref y, ref c);
                    for (int j = 0; j < a.Length; j++)
                    {
                        if (a[j] == b[j])
                            continue;
                        else
                            return h = false;
                    }

                }


            }
            return h;
        }

        static void Main(string[] args)
        {
            int[] a = { 1, 1, 4 };
            int[] b = { 1, 2, 3 };
            areSimilar(a, b);
        }
    }
}
