using System;

namespace Tutlane
{
    class User
    {
        public User()
        {
            Console.WriteLine("An Instance of class created");
        }
        // Destructor
        ~User()
        {
            Console.WriteLine("An Instance of class destroyed");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Details();
            GC.Collect();
            Console.ReadLine();
        }
        public static void Details()
        {
            // Created instance of class
            User user = new User();
        }
    }
}