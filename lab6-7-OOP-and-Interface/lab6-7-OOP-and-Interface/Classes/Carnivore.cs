using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_7_OOP_and_Interface.Classes
{
    public abstract class Carnivore : Mammal
    {
        public override sealed string Food { get; set; } = "Meat";
        public abstract bool Hibernation { get; set; }
        public virtual bool CampingCrasher { get; set; } = true;
        public string PredatorPrey { get; set; } = "Predator";
        public virtual bool WasInJungleBook { get; set; } = true;

        /// <summary>
        /// Method being overriden from `Animal` base to return a string
        /// </summary>
        public override string Bark()
        {
            return "Rawr";
        }
        /// <summary>
        /// Trait that is being passed from mammal,being overriden to return a string
        /// </summary>
        public override void Hunting()
        {
            Console.WriteLine("Dinner time gotta go hunting!");
        }

        /// <summary>
        /// The method passed from `Animal`base, which will be overriden and write in console a string.
        /// </summary>
        public sealed override void Migrating()
        {
            Console.WriteLine("I am going to stick around my zone! Stay out!");
        }

    }
}
