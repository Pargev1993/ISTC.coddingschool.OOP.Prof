using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.codingschool.OOP.Reflection.Assembly
{
  public  class Porshe:MyCar
    {
        public Porshe() { }
        public Porshe(string name, int currentSpeed, int maxSpeed)
            : base(name, currentSpeed, maxSpeed) { }

        public override void Acceleration()
        {
            State = EngineState.EngineAlive;
            Console.WriteLine("Porshe: Engine Alive");
        }

    }

    internal  class SecretCar:MyCar
    {
        public override void Acceleration()
        {
            
        }
    }
}
