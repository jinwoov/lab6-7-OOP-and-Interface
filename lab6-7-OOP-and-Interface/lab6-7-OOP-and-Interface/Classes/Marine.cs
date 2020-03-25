using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_7_OOP_and_Interface.Classes
{
    abstract class Marine : Fish
    {
        public override string Food { get; set; } = "Coral Reef";

        public virtual string FishAreFriend()
        {
            return "Fishes are friend, Not food!";
        }

    }
}
