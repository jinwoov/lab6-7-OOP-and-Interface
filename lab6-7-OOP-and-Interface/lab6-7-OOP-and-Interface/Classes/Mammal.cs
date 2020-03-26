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

        // <summary>
        /// Method that will be shared by other descendents and when called by child, it will know this method
        /// </summary>
        public void Walking()
        {
            Console.WriteLine($" {Name} is walking like a McJagger");
        }

        // <summary>
        /// Method that will be overriden from `Animal` class and will return different string;
        /// </summary>
        public override sealed string Sleeping()
        {
            return "Zzz to the dream land";
        }

    }
}
