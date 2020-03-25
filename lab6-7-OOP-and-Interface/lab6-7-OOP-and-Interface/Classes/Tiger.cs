using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_7_OOP_and_Interface.Classes
{
    class Tiger : Canivore
    {
        public override bool Hibernation { get; set; } = false;
        public override bool PackAnimals { get; set; } = false;
        public override bool CampingCrasher { get; set; } = false;

    }
}
