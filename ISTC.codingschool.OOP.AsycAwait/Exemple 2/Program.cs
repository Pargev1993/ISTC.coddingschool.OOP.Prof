using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exemple_2
{
    class MyClass
    {
        public void Operation()
        {
            Thread.Sleep(2000);
            Console.WriteLine("General Task");
        }
        public async Task OperationAsync()
        {
            await Task.Factory.StartNew(Operation);
            Console.WriteLine("Hello");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Task task = myClass.OperationAsync();
            task.ContinueWith(t => Console.WriteLine("Continue Task!"));
            Console.ReadLine();

        }
        
    }
}
