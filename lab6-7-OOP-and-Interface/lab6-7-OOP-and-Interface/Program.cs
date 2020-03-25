using System;
using lab6_7_OOP_and_Interface.Classes;
using lab6_7_OOP_and_Interface.Interface;


namespace lab6_7_OOP_and_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance Zone");
            Classes();

            Console.WriteLine("Interface Zone");

            TheInterFace();
        }

        static void TheInterFace()
        {
            IKingOfAnimals[] king = new IKingOfAnimals[2];

            king[0] = new Lion();
            king[1] = new GreatWhiteShark();

            king[1].Attention();
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
