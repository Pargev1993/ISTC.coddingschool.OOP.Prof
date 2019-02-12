using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_18
{
    class Program
    {
        public static bool palindromeRearranging(string myString)
        {
            char[] arr = myString.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != arr[arr.Length-(i+1)])
                {
                    
                  arr[arr.Length - (i + 1)]=arr[i];
                    break;
                    
                }
               
               
            }
            string first = myString.Substring(0, myString.Length / 2);
            


            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);

        }
        static void Main(string[] args)
        {
            string s = "zyyzzzzz";
            palindromeRearranging(s);
        }
    }
}
