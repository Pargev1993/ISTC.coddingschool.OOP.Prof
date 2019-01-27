using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using SortingGeneric;

namespace ReflectionDll
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Sort);
            MethodInfo[] methodInfos = type.GetMethods();
            foreach (var item in methodInfos)
            {
                Console.WriteLine(item.Name);
                
            }
            Console.WriteLine(new string('-',25));

            FieldInfo [] fileInfos = type.GetFields();
            foreach (var item in fileInfos)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine(new string('-', 25));

            MemberInfo[] memberInfos = type.GetMembers();
            foreach (var item in memberInfos)
            {
                Console.WriteLine(item);
               
            }

            
         
        }
        
        

    }
}
