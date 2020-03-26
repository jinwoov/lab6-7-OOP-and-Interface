using lab6_7_OOP_and_Interface.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_7_OOP_and_Interface.Classes
{
    public abstract class Fish : Animal, ISwim
    {
        public bool HasGill { get; set; } = true;
        public override string BloodTemperature { get; set; } = "Cold";
        public override string Habitat { get; set; } = "Underwater";
        public override int LegAmount { get; set; } = 0;
        public bool HasFin { get; set; } = true;

        /// <summary>
        /// This is virtual method that is being passed to all of the fish
        /// </summary>
        public virtual string Swimming()
        {
            return "Just keep swimming";
        }

        /// <summary>
        /// Migrating method that is passed from base `Animal` base class, which is now being overriden and sealed to be pass to descendents without any allowing any changes
        /// </summary>
        public override sealed void Migrating()
        {
            Console.WriteLine("I am always on the move for new place"); 
        }

        /// <summary>
        /// Method that is passed from parent, `Animal`, class that is being overriden and sealed to return a string.
        /// </summary>
        public sealed override string Sleeping()
        {
            return "I dont sleep I keep my eyes wide open";
        }

        /// <summary>
        /// Method that is from interface and will be pass to any descendent from this point.
        /// </summary>
        public void WiggleTail()
        {
            Console.WriteLine("Wiggle Wiggle Wiggle dodododo");
        }

        /// <summary>
        /// Method that is from interface and will be pass to any descendent from this point.
        /// </summary>
        public string SwimFast()
        {
            return "Theres food catch him";
        }
    }
}
