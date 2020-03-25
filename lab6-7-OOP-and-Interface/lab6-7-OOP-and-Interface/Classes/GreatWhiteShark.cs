using lab6_7_OOP_and_Interface.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_7_OOP_and_Interface.Classes
{
    public class GreatWhiteShark : Marine, IKingOfAnimals
    {
        public void Attention()
        {
            Console.WriteLine("duh duh. duh duh. duh duh duh duh dudh duh(Shark song)");
        }

        public override string FishAreFriend()
        {
            Food = "Fish";
            return Food;
        }

        public void RunWhenYouSeeMe()
        {
            Console.WriteLine("Spoink Run Away!");
        }
    }
}
