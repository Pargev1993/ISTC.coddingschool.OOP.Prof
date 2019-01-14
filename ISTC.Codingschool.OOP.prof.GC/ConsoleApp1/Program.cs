using System;

namespace Exemple_2

{
    class FinalizeObject
    {
        public int id { get; set; }

        public FinalizeObject(int id)
        {
            this.id = id;
        }

        // Let's create a special destructor
        ~FinalizeObject()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The № {0} object has been destroyed", id);
            Console.Beep();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Read();
            // After the Enter key is pressed (exiting the program)
            //All subsequent objects will be destroyed

            FinalizeObject[] obj = new FinalizeObject[100];
            for (int i = 0; i < 100; i++)
            {
                obj[i] = new FinalizeObject(i);
                Console.WriteLine("Files hase been created {0}",i);
            }
        }
    }
}