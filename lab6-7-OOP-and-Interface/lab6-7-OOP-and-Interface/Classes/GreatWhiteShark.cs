using lab6_7_OOP_and_Interface.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_7_OOP_and_Interface.Classes
{
    public class GreatWhiteShark : Marine, IKingOfAnimals
    {
        /// <summary>
        /// Method that is from `IKingOfAnimals` and having it return a string.
        /// </summary>
        public string Attention()
        {
            return "duh duh. duh duh. duh duh duh duh dudh duh(Shark song)";
        }

        /// <summary>
        /// Method that is from `Marine` class, and is being overriden here to return Food, which is changed from algae to fish.
        /// </summary>
        public override string FishAreFriend()
        {
            Food = "Fish";
            return Food;
        }

        /// <summary>
        /// Method that is unique to `GreatWhiteShark` is returning a string in console line
        /// </summary>
        public void ThemeSong()
        {
            Console.WriteLine("Baby shark do do do do do do~");
        }

        /// <summary>
        /// Method that is from `IKingOfAnimals` and having it return a string
        /// </summary>
        public void RunWhenYouSeeMe()
        {
            Console.WriteLine("Spoink Run Away!");
        }
    }
}
