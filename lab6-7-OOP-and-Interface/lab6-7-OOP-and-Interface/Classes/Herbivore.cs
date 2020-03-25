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

        public override void Hunting()
        {
            Console.WriteLine("I dont need to hunt, when I got hooman");
        }

        public virtual string Jumping()
        {
            return "Gravity is so heavy";
        }

        public override string Bark()
        {
            return "I dont bark! I scream";
        }

        public override void Migrating()
        {
            Console.WriteLine("I don't need to leave my house to get food. Its deliver daily by hooman");
        }

    }
}
