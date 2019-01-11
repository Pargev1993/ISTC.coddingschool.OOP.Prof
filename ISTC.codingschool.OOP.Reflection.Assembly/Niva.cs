using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.codingschool.OOP.Reflection.Assembly
{
  public   class Niva : MyCar
    {
        public Niva() { }
        
        public Niva(string name,int currentSpeed,int maxSpeed)
            : base(name, currentSpeed, maxSpeed) { }
        
        public override void Acceleration()
        {
            State = EngineState.EngineDead;
            Console.WriteLine("NIVA:Engine Dead");

        }
    }
}
