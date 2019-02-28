using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Exemple_1
{
    public delegate void ArrayDel(ref int [] x);
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[25];
            num.AddNumbers();
            ArrayDel arrayDel;
            ArrayDel array = OperationWithArray.GetPairsNumbers;
            arrayDel = array;
            arrayDel+=OperationWithArray.GetOddNumbers;
            arrayDel(ref num);

        }
    }
}
