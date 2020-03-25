using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_7_OOP_and_Interface.Classes
{
    public class GreatWhiteShark : Marine
    {
        public override string FishAreFriend()
        {
            Food = "Fish";
            return Food;
        }
    }
}
