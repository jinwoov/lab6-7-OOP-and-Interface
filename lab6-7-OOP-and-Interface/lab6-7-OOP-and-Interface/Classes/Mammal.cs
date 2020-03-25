using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_7_OOP_and_Interface.Classes
{
    public abstract class Mammal : Animal
    {
        public override string BloodTemperature { get; set; } = "Warm";
        public override int LegAmount { get; set; } = 4;
        public override string Habitat { get; set; } = "Land";
        public bool LiveBirth = true;
        public virtual string Name { get; set; } =  "";

        public abstract bool PackAnimals { get; set; }

        public abstract string Bark();
        public void Walking()
        {
            Console.WriteLine($" {Name} is walking like a McJagger");
        }
        public abstract void Hunting();
        public override sealed string Sleeping()
        {
            return "Zzz to the dream land";
        }

    }
}
