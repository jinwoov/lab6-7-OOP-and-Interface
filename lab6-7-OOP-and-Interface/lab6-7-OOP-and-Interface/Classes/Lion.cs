using lab6_7_OOP_and_Interface.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_7_OOP_and_Interface.Classes
{
    public class Lion : Carnivore, IKingOfAnimals, ISwim
    {
        public override bool Hibernation { get; set; } = false;
        public override bool PackAnimals { get; set; } = true;
        public override bool CampingCrasher { get; set; } = false;
        public override bool WasInJungleBook { get; set; } = false;
        public bool HasFin { get; set; } = false;

        /// <summary>
        /// Method that is from interface `IKingOfAnimals`
        /// </summary>
        public string Attention()
        {
            return "Circle of Life";
        }

        /// <summary>
        /// Unique method that is just for lion class
        /// </summary>
        public void Hakunamatata()
        {
            Console.WriteLine("IT MEANS NO WORRIES FOR THE REST OF THE DAY");
        }

        /// <summary>
        /// Method that is passed on from IKingOfAnimals class
        /// </summary>
        public void RunWhenYouSeeMe()
        {
            Console.WriteLine("Duck Duck Run!");
        }

        /// <summary>
        /// Method that been passed from ISwim method that returns string value.
        /// </summary>
        public string SwimFast()
        {
            return "I dont swim, I eat";
        }

        // <summary>
        /// Method that been passed from ISwim interface ans is retuning line on console
        /// </summary>
        public void WiggleTail()
        {
            Console.WriteLine("I guess I am prowling");
        }
    }
}
