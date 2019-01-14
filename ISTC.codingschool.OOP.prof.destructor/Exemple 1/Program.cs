using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class MyClass
    {
        int k;

        public MyClass(int i)
        {
            k = i;
        }

        ~MyClass()
        {
            Console.WriteLine("object {0} destroyed ", k);
        }

        public void objectGenerator(int i)
        {
            MyClass ob = new MyClass(i);
            Console.WriteLine(ob.k);
            Thread.Sleep(10);
        }
    }

    class Program
    {
        static void Main()
        {
            int i = 1;
            MyClass obj = new MyClass(0);

            for (; i < 120000; i++)
            {
                obj.objectGenerator(i);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("End");

            Console.ReadLine();
        }
    }
}