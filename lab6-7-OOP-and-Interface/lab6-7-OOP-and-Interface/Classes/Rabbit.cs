using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_7_OOP_and_Interface.Classes
{
    public class Rabbit : Herbivore
    {
        public void Thumping()
        {
            Console.WriteLine("Alert Hooman's coming");
        }
        public override string Jumping()
        {
            return "Hip hop Hipty hop";
        }
    }
}
