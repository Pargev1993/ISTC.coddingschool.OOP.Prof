using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ISTC.codingschool.OOP.Attribut.exem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Name = "Porshe";
            Type type = typeof(Car);
            FieldInfo[] genericParameter = type.GetFields();
            foreach (var item in genericParameter)
            {
                Console.WriteLine(item.Name);
            }
            
        }
    }
}
