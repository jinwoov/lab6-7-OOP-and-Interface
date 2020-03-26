using System;
using lab6_7_OOP_and_Interface.Classes;
using lab6_7_OOP_and_Interface.Interface;


namespace lab6_7_OOP_and_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Showing the example of inheritance");
            InheritanceExample();
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Showing the example of interface");
            TheInterFace();
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Showing the example of polymorphism");
            Polymorphism();
            Console.WriteLine("-----------------------------------");

        }

        /// <summary>
        /// This is the method that show case how spcific animal can access interface  IKingOfAnimals.
        /// </summary>
        static void TheInterFace()
        {
            IKingOfAnimals[] king = new IKingOfAnimals[2];

           
            king[0] = new Lion();
            king[1] = new GreatWhiteShark();

            for (int i = 0; i < king.Length; i++)
            {
                var kingDom = king[i];

                if(kingDom is Lion)
                {
                    var simba = (Lion)kingDom;
                    simba.Hakunamatata();
                }
                else
                {
                    var babyShark = (GreatWhiteShark)kingDom;
                    babyShark.ThemeSong();
                }
            }
        }

        /// <summary>
        /// This method examplifies all the animals being able to access method that was declared in mammal class.
        /// </summary>
        static void InheritanceExample()
        {
            Mammal[] mammal = new Mammal[3];

            mammal[0] = new Cow();
            mammal[1] = new Wolf();
            mammal[2] = new Bear();

            for (int i = 0; i < mammal.Length; i++)
            {
               mammal[i].Walking();
            }
        }
        
        /// <summary>
        /// This method is showcase how polymorphism is effecting rabbit class. By overriding Jumping method in the rabbit, cow which inherited from Herbivore stays the same but rabbit is different.
        /// </summary>
        static void Polymorphism()
        {
            Cow moo = new Cow();

            Console.WriteLine("This is without polymorphism");
            Console.WriteLine(moo.Jumping());

            Rabbit peter = new Rabbit();

            Console.WriteLine("This is with polymorphism applied");
            Console.WriteLine(peter.Jumping());
        }
    }
}
