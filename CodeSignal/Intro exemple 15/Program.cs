using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace Intro_exemple_15
{
    class Program
    {
        public static string[] addBorder(string[] picture)
        {
            int res = 0;
            for (int i = 0; i < picture.Length; i++)
            {
                if (picture[i].Length > res)
                {
                    res = picture[i].Length;
                    Console.WriteLine(res);
                }
               
            }

           string [] vs = new string[picture.Length+2];
            vs[0]= new string('*', res + 2);
            for (int i = 1; i < picture.Length+1; i++)
            {
             vs[i]=(  picture[i-1] = $"*{picture[i-1]}*");
            }
            vs[picture.Length+1]=(new string('*', res+2));
            return vs;
        }


        static void Main(string[] args)
        {
       string[] picture ={"abc", "ded"};
            addBorder(picture);
        }
    }
}
