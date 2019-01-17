using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exemple_1
{
    class Myclass
    {
       public void Operation()
        {
            Console.WriteLine($"thread Id {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Begin");
            Thread.Sleep(2000);
            Console.WriteLine("End");
        }

        public void Operation2()
        {
            Console.WriteLine($"thread Id {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Begin");
            Thread.Sleep(2000);
            Console.WriteLine("End");
        }
        public async void AoperationAsync()
        {
            Console.WriteLine($"OperationAsync (Part1) Thread ID {Thread.CurrentThread.ManagedThreadId}");
            Task task = new Task(Operation);
            task.Start();
            await task;
            Task task2 = new Task(Operation2);
            task2.Start();
            await task2;
            Thread.Sleep(200);
            Console.WriteLine($"OperationAsync (Part2) Thread ID {Thread.CurrentThread.ManagedThreadId}");

        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread ID {Thread.CurrentThread.ManagedThreadId}");
            Myclass myclass = new Myclass();
            myclass.AoperationAsync();

            Console.WriteLine($"Main2 Thread ID {Thread.CurrentThread.ManagedThreadId}");
            Console.ReadLine();
        }
    }
}
