using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_7_OOP_and_Interface.Classes
{
    class GreatWhiteShark : Marine
    {
        public override string Food { get; set; } = "Fish";
        public override string FishAreFriend()
        {
            return "I smell blood! Fishes are FOOD!";
        }
    }
}
