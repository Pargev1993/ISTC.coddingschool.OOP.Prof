using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_14
{
    class Program
    {
        public static int[] alternatingSums(int[] a)
        {
            int sd = 0;
            int ka = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(i==0 && i%2==0)
                {
                    ka += a[i];
                }
                else
                {
                    sd += a[i];
                }
            }
            int[] b = { sd, ka };
            return b;
        }
        static void Main(string[] args)
        {
            int[] oi =  { 100, 50 };
           // Random random = new Random();
            //for (int i = 0; i < oi.Length; i++)
            //{
            //    oi[i] = random.Next(1, 35);
            //}
            alternatingSums(oi);
        }
    }
}
