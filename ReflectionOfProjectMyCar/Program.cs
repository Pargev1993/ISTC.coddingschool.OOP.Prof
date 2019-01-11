using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using ISTC.codingschool.OOP.Reflection.Assembly;
using System.Reflection;

namespace ReflectionOfProjectMyCar
{
    class Program
    {
        public static void MethodA(Assembly assembly)
        {
            Console.WriteLine(assembly.FullName);
            Type[] types = assembly.GetTypes();
            foreach (var item in types)
            {
                Console.WriteLine(item);
            }
        }
        public static void MenberInf(Assembly assembly)
        {
            Type type = typeof(Niva);
            MemberInfo[] infos = type.GetMembers();
            foreach (var item in infos)
            {
                Console.WriteLine("{0,-15}: {1}",item.MemberType,item);
            }
        }
        public static void GetParams(Assembly assembly)
        {
            Type type = typeof(Porshe);
            MethodInfo methodInfo = type.GetMethod("Driver");
            ParameterInfo[] parameterInfo = methodInfo.GetParameters();
            foreach (var item in parameterInfo)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Position);
                Console.WriteLine(item.ParameterType);
            }
        }
        static void Main(string[] args)
        {
            Assembly assembly = null;
            try
            {
                assembly = Assembly.Load("ISTC.codingschool.OOP.Reflection.Assembly");
                Console.WriteLine("Loadid");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            MethodA(assembly);
            MenberInf(assembly);

            GetParams(assembly);

        }
    }
}
