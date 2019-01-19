using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Exempl
{
    class Program
    {
        static void Main(string[] args)
        {
            var Item = new Stack<string>();
            Item.Push("https://programmingwithmosh.com/csharp/csharp-collections/");
            var contains = Item.Contains("https://programmingwithmosh.com/csharp/csharp-collections/");
           // var pop = Item.Pop();
            Item.Peek();
            var count = Item.Count;
            Item.Clear();

        }
    }
}
