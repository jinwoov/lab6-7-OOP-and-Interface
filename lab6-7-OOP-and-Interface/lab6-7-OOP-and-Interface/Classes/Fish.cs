using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_7_OOP_and_Interface.Classes
{
    public abstract class Fish : Animal
    {
        public bool HasGill { get; set; } = true;
        public override string BloodTemperature { get; set; } = "Cold";
        public override string Habitat { get; set; } = "Underwater";
        public override int LegAmount { get; set; } = 0;

        public virtual string Swimming()
        {
            return "Just keep swimming";
        }

        public override sealed void Migrating()
        {
            Console.WriteLine("I am always on the move for new place"); 
        }

        public sealed override string Sleeping()
        {
            return "I dont sleep I keep my eyes wide open";
        }

    }
}
