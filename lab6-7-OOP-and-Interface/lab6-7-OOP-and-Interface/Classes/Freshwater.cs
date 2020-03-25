using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_7_OOP_and_Interface.Classes
{
    public abstract class Freshwater : Fish
    {
        public bool LandAnimalEncounter { get; set; } = true;

        public sealed override string Food { get; set; } = "Algae";

        public virtual bool CatchRelease()
        {
            return false;
        }
    }
}
