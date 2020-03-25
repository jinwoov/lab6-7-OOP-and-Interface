using lab6_7_OOP_and_Interface.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_7_OOP_and_Interface.Classes
{
    public class GreatWhiteShark : Marine, IKingOfAnimals
    {
        public string Attention()
        {
            return "duh duh. duh duh. duh duh duh duh dudh duh(Shark song)";
        }

        public override string FishAreFriend()
        {
            Food = "Fish";
            return Food;
        }

        public void ThemeSong()
        {
            Console.WriteLine("Baby shark do do do do do do~");
        }

        public void RunWhenYouSeeMe()
        {
            Console.WriteLine("Spoink Run Away!");
        }
    }
}
