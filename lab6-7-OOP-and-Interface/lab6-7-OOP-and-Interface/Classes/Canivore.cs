using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_7_OOP_and_Interface.Classes
{
    public abstract class Canivore : Mammal
    {
        public override sealed string Food { get; set; } = "Meat";
        public abstract bool Hibernation { get; set; }
        public virtual bool CampingCrasher { get; set; } = true;

        public string PredatorPrey { get; set; } = "Predator";

        public virtual bool WasInJungleBook { get; set; } = true;

        public override string Bark()
        {
            return "Rawr";
        }

        public override void Hunting()
        {
            Console.WriteLine("Dinner time gotta go hunting!");
        }

        public sealed override void Migrating()
        {
            Console.WriteLine("I am going to stick around my zone! Stay out!");
        }

    }
}
