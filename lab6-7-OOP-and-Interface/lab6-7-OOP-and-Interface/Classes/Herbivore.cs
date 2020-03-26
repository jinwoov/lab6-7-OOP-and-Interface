using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_7_OOP_and_Interface.Classes
{
    public abstract class Herbivore : Mammal
    {
        public override sealed string Food { get; set; } = "Vegetation";
        public override sealed bool Domesticatable { get; set; } = true;
        public string PredatorPrey { get; set; } = "Prey";
        public override sealed bool PackAnimals { get; set; } = true;

        /// <summary>
        /// Method that is being passed from `Mammal` which is being overriden to return a line in console.
        /// </summary>
        public override void Hunting()
        {
            Console.WriteLine("I dont need to hunt, when I got hooman");
        }

        /// <summary>
        /// For future use but is being passed in herbivore animals
        /// </summary>
        public virtual string Jumping()
        {
            return "Gravity is so heavy";
        }

        /// <summary>
        /// The method that is from mammal and will be overriden and return a string value;
        /// </summary>
        public override string Bark()
        {
            return "I dont bark! I scream";
        }

        /// <summary>
        /// Method that is from animal class and has been passed on to herbivore.
        /// </summary>
        public override void Migrating()
        {
            Console.WriteLine("I don't need to leave my house to get food. Its deliver daily by hooman");
        }

    }
}
