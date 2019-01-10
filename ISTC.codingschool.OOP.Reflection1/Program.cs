using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ISTC.codingschool.OOP.Reflect
{
    class Program
    {
        static void Method1(Persone persone)
        {
            Type t = persone.GetType();
            Console.WriteLine(" base Type: {0} ", t.BaseType);
            Console.WriteLine("Full Name {0}", t.FullName);
            Console.WriteLine("Name {0}", t.Name);
            Console.WriteLine("Is COM Object: {0}", t.IsCOMObject);
            Console.WriteLine("Is Auto Layout {0}", t.IsAutoLayout);
            Console.WriteLine("Is Auto Class {0}", t.IsAutoClass);
            Console.WriteLine("Is Generic Type {0}", t.IsGenericType);
            Console.WriteLine("IS Class {0}", t.IsClass);
        }
        static void Method2(Persone persone)
        {
            Console.WriteLine(new string('_', 30));
            Type t = persone.GetType();
            MethodInfo[] info = t.GetMethods(BindingFlags.Static | BindingFlags.SetField
                | BindingFlags.NonPublic | BindingFlags.Default | BindingFlags.Instance | BindingFlags.InvokeMethod | BindingFlags.Public);
            foreach (var item in info)
            {
                Console.WriteLine(item.Name);
            }


        }
        static void Method3(Persone persone)
        {
            Console.WriteLine(new string('_', 30));
            Type t = persone.GetType();
            FieldInfo[] info = t.GetFields(BindingFlags.Static | BindingFlags.SetField
                | BindingFlags.NonPublic | BindingFlags.Default | BindingFlags.Instance | BindingFlags.InvokeMethod | BindingFlags.Public);
            foreach (FieldInfo item in info)
            {
                Console.WriteLine(item.Name);
            }
        }
        static void Method4(Persone persone)
        {
            Console.WriteLine(new string('_', 30));
            Type t = persone.GetType();
            PropertyInfo[] info = t.GetProperties(BindingFlags.Static | BindingFlags.SetField
                | BindingFlags.NonPublic | BindingFlags.Default | BindingFlags.Instance | BindingFlags.InvokeMethod | BindingFlags.Public);
            foreach (PropertyInfo item in info)
            {
                Console.WriteLine(item.Name);
            }
        }

        static void Method5(Persone persone)
        {
            Console.WriteLine(new string('_', 30));
            Type t = persone.GetType();
            Type[] info = t.GetInterfaces();

            foreach (Type item in info)
            {
                Console.WriteLine(item.Name);
            }
        }
        static void Main(string[] args)
        {
            Type type = typeof(Persone);
            TypeInfo typeInfo = type.GetTypeInfo();
            IEnumerable<FieldInfo> propertyInfos = typeInfo.DeclaredFields;
            foreach (var item in propertyInfos)
            {
                Console.WriteLine(item.Name);
            }
            IEnumerable<MethodInfo> methods = typeInfo.DeclaredMethods;
            foreach (var sdd in methods)
            {
                Console.WriteLine(sdd.Name);
            }

            Persone persone = new Persone();
            Type Typeoff;
            type = persone.GetType();
            Console.WriteLine(type);
            var s = type.Name;
            type = Type.GetType("ISTC.codingschool.OOP.Reflect.Persone");
            Console.WriteLine(type);
            type = typeof(Persone);
            Console.WriteLine(type);
            var d = type.GetTypeInfo();
            Console.WriteLine(d);
            type.GetRuntimeProperty(" ");
            var t = type.TypeInitializer;
            Method1(persone);
            Method2(persone);
            Method3(persone);
            Method4(persone);
            Method5(persone);
            MethodInfo info = type.GetMethod("MethodC", BindingFlags.Instance | BindingFlags.NonPublic);
            info.Invoke(persone, new object[] { 15, 16 });
            FieldInfo fieldInfo = type.GetField("Name", BindingFlags.Instance | BindingFlags.NonPublic);
            fieldInfo.SetValue(persone, "Armen");
            Console.WriteLine(new string('_', 30));
            Console.WriteLine(persone.Name);
            Console.WriteLine(info);
            Type T = typeof(Persone);




        }
    }
}
