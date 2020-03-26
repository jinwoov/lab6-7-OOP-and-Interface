using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_7_OOP_and_Interface.Classes
{
    public class Bass : Freshwater
    {
        /// <summary>
        /// Overriding the `FreshWater` method that has it false
        /// </summary>
        public override bool CatchRelease()
        {
            return true;
        }

    }
}
