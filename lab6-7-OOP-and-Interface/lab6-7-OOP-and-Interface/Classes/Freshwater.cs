using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_7_OOP_and_Interface.Classes
{
    public abstract class Freshwater : Fish
    {
        public bool LandAnimalEncounter { get; set; } = true;

        public sealed override string Food { get; set; } = "Algae";

        /// <summary>
        /// Method that will be passed on any `FreshWater` child. However will be overriden again due to virtual tag
        /// </summary>
        public virtual bool CatchRelease()
        {
            return false;
        }
    }
}
