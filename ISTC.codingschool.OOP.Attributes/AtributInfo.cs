using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.codingschool.OOP.Attributes
{
    class AttInfo:System.Attribute
    {

        public string Name { get; set; } = "Pargev";
        public int Code { get; set; }
        public AttInfo() { }
        public AttInfo(string name,int Code)
        {
            Name = name;
           this.Code = Code;
        }

    }
}
