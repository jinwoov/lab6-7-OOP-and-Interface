using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_7_OOP_and_Interface.Classes
{
    public class Bear : Carnivore
    {
        public override bool Hibernation { get; set; } = true;
        public override bool PackAnimals { get; set; } = false;

    }
}
