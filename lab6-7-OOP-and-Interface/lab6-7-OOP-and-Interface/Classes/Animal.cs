using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_7_OOP_and_Interface.Classes
{
    public abstract class Animal
    {
        public abstract string Food { get; set; }
        public virtual bool Domesticatable { get; set; } = false;
        public abstract string Habitat { get; set; }
        public abstract string BloodTemperature { get; set; }
        public abstract int LegAmount { get; set; }

        public abstract void Migrating();

        public string Eating()
        {
            return "Hey I am eating here come back later";
        }

        public abstract string Sleeping();

    }
}
