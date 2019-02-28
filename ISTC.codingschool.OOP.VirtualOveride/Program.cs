using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.codingschool.OOP.VirtualOveride
{
    class Persone
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Persone(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void method()
        {
            Console.WriteLine($"{Name}, {Age}");
        }
    }
    class Director : Persone
    {
        public string Company { get; set; }

        public Director(string name, int age, string company)
            : base(name, age)
        {
            Company = company;
        }
        public override void method()
        {
            Console.WriteLine($"{Name}, {Age},{Company}");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Persone persone = new Persone("Bob", 24);
            persone.method();
            //Persone persone = director;
            Director director = new Director("Bob", 25, "holla");
            persone = director;
            persone.method();
            persone.method();


        }
    }
}
