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
            int t = 0;
            int d = 0;
            int s = 0;
            if ((a.Length/2)%2!=0 && a.Length/2!=1)
            {
                s = a.Length / 2 + 1;
            }
            else
            {
                s = a.Length / 2;
            }
            
            for (int i = 0; i <s; i++)
            {
                t += a[i];
              
                Console.WriteLine(t);
            }
            for (int j = s;j<a.Length ; j++)
            {
                d += a[j];
               
                Console.WriteLine(d);
            }
            int[] b = { t, d };
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
