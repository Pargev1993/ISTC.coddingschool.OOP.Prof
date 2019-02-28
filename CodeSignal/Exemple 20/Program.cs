using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_20
{
    class Program
    {
        public static bool isIPv4Address(string inputString)
        {
            bool c = false;
            int s = 0;
            string[] t = inputString.Split('.');
            if (t.Length == 4)
            {
                for (int i = 0; i < t.Length; i++)
                {
                    try
                    {
                        s = int.Parse(t[i]);
                        if (s > 255)
                        {
                            c = false;
                            break;
                        }

                        else
                            c = true;
                    }
                    catch
                    {
                        return c = false;
                    }


                }
            }
            return c;
        }

        static void Main(string[] args)
        {
            string s = "1.256.1.1";
            isIPv4Address(s);


        }
    }
}
