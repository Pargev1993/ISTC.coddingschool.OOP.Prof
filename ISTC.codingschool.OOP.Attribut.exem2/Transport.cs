using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.codingschool.OOP.Attribut.exem2
{ 
     class Transport:System.Attribute
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Wheel { get; set; }
        public bool Doors { get; set; }
        private int Speed;
        private double Weight;
        

        public Transport(string name, string color, int wheel)
        {
            Name = name;
            Color = color;
            Wheel = wheel;
        }

      

        public int speed
        {
            get { return Speed; }
            set
            {
                if (Speed > 280)
                {
                    value = (int)EngineState.EngineDead;
                }
                else
                {
                    value = Speed;
                }
            }
        }
        public double weight
        {
            get => Weight;
            set => value = Weight;
        }
    }
}
