using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_13
{
    class Program
    {
        public static List<char>  Word(string s)
        {
            List<char> Lchar = new List<char>();
            Lchar.AddRange(s);
            int d=0;
            int t = 0;
            int c = 1;
            foreach (var item in Lchar)
            {
                d++;
               if(item=='(')
                {
                    t = d;
                    while (Lchar[d] != ')')
                    {
                      
                        Lchar[t +(t- c-1)] = Lchar[d];
                        Lchar[d] = Lchar[t + (t - c - 1)];
                          d++;
                        c++;
                    } 
                }
            }
            return Lchar;


        }
        static void Main(string[] args)
        {
            string S = "love(Helo)Boy";
            Word(S);
        }
    }
}
