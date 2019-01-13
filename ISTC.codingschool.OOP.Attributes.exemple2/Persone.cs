using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ISTC.codingschool.OOP.Attributes.exemple2
{
    class Persone:System.Attribute
    {
        [AttributeUsage]
        [req]
        public string LastName { get; set; }


    }
}
