using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ISTC.codingschool.OOP.Attributes
{
  public  class User:System.Attribute
    {
        [AttInfo(Code = 15, Name = "Անուն")]
        [JsonProperty("first Name")]
        public string Name { get; set; }
        public int Age { get; set; }
        public User(string n,int a)
        {
            Name = n;
            Age = a;
        }
        private int Payment(int hours, int perhour)
        {
            return hours * perhour;
        }
    }
}
