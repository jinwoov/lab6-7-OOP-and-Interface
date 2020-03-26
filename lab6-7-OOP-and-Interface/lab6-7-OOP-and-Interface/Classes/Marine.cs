using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_7_OOP_and_Interface.Classes
{
    public abstract class Marine : Fish
    {
        public override string Food { get; set; } = "Coral Reef";

        /// <summary>
        /// Method that originally from `Animal`, and it will be overriden and return a different string;
        /// </summary>
        public virtual string FishAreFriend()
        {
            return "Fishes are friend, Not food!";
        }

    }
}
