using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_1
{
    class UserInfo
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public UserInfo(string Name,int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Basic information about the system");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"Operating system: {0} Version .NET Framework: {1}", Environment.OSVersion, Environment.Version);
            Console.WriteLine("@ Number of bytes in the heap: {0} ", GC.GetTotalMemory(true)); 
            UserInfo userInfo = new UserInfo("Alex", 25);
            Console.WriteLine(GC.GetGeneration(userInfo));
            for (int i = 0; i < 50000; i++)
            {
                UserInfo user = new UserInfo("DAN", 27);
            }
            GC.Collect(0, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();
            Console.WriteLine("\ngarbage Collection ...\n");

            Console.WriteLine("Now the generation of the Userinfo object: " + GC.GetGeneration(userInfo));
        }
    }
}
