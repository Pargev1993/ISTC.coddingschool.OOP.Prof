using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.codingschool.OOP.Reflection.Assembly
{
    public abstract class MyCar
    {
        protected string name;
        protected int currentSpeed;
        protected int maxSpeed;
        protected EngineState State;
        protected MyCar()
        {
            State = EngineState.EngineAlive;
        }
        protected MyCar(string name,int currentSpeed,int maxspeed)
        {
            this.name = name;
            this.currentSpeed = currentSpeed;
            this.maxSpeed = maxSpeed;
        }

        public abstract void Acceleration();
        public void Driver(string name, int age)
        {
            Console.WriteLine("Driver Name {0}. Age {1}", name, age);
        }
       public string Name
        {
            get { return name; }
            set { value = name; }
        }
        public int CurrentSpeed
        {
            get { return currentSpeed; }
            set { value = currentSpeed; }
        }
        public int MaxSpeed
        {
            get { return maxSpeed; }
            set { value = maxSpeed; }
        }
        public EngineState EngineState
        {
            get { return State; }
        }

    }
}
