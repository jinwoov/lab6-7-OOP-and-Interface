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
            Classes();
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Showing the example of interface");
            TheInterFace();
        }

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

        static void Classes()
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
    }
}
