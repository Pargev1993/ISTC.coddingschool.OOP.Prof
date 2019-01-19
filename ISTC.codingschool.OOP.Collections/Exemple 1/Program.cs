using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>(150);
            list.Add(4);
            list.Insert(0, 24);
            list.Insert(0, 25);
            list.Remove(4);
            list.Insert(0, 4);
            var first = list[0];
            var index = list.IndexOf(24);
            var contains = list.Contains(4);
            var contain = list.Contains(4);
        }
    }
}
