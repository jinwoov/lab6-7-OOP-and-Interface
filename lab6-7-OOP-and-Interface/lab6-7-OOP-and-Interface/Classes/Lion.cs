using lab6_7_OOP_and_Interface.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_7_OOP_and_Interface.Classes
{
    public class Lion : Carnivore, IKingOfAnimals
    {
        public override bool Hibernation { get; set; } = false;
        public override bool PackAnimals { get; set; } = true;
        public override bool CampingCrasher { get; set; } = false;
        public override bool WasInJungleBook { get; set; } = false;

        public void Attention()
        {
            Console.WriteLine("Circle of Life");
        }

        public void Hakunamatata()
        {
            Console.WriteLine("IT MEANS NO WORRIES FOR THE REST OF THE DAY");
        }

        public void RunWhenYouSeeMe()
        {
            Console.WriteLine("Duck Duck Run!");
        }
    }
}
