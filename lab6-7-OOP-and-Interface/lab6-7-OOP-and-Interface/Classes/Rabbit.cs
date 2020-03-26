using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_7_OOP_and_Interface.Classes
{
    public class Rabbit : Herbivore
    {
        /// <summary>
        /// Method that is unique to this class and return console message
        /// </summary>
        public void Thumping()
        {
            Console.WriteLine("Alert Hooman's coming");
        }

        /// <summary>
        /// this method is being overriden and is from herbivore class. Just because rabbit CAN jump
        /// </summary>
        public override string Jumping()
        {
            return "Hip hop Hipty hop";
        }
    }
}
