using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.codingschool.OOP.Reflect
{
    class Persone : INtercase1,INterface2
    {
        public string Name { get; } = "Albert";
        public int Age { get; private set; } = 25;
        public Double Highe { get; private set; } = 169.25;
        public void GetAge()
        {
            Console.WriteLine(Age);
        }
        public void GetName()
        {
            Console.WriteLine(Name);
        }
        void INtercase1.MethodeA() { }
        void INterface2.MethodB() { }
        public Persone()
        {

        }
        public Persone(string name, int age)
        {
            Name = name;
            Age = age;
        }
        private int MethodC(int age, int highe)
        {
            return age + (int)highe;
        }

       
       
    }
}
