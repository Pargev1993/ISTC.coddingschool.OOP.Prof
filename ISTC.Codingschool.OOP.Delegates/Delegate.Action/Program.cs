using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Actions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[25];
            num.AddNumbers();
            Action<int []> action;
            action = Add;
            action += SortArray;
            DelegateCall(num, action);
        }
        public static void SortArray( int[] array)
        {
            int length = array.Length;

            int temp = array[0];

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];

                        array[i] = array[j];

                        array[j] = temp;
                    }
                }
            }
        }
        public static void Add( int []x)
        {
            for (int i = 1; i < x.Length; i++)
            {
              var s=  x[i] + x[i - 1];
            }
        }
        public static void DelegateCall(int [] x,Action <int []> action)
        {
            action(x);
        }
    }
}
