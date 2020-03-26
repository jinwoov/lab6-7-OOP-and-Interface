using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_7_OOP_and_Interface.Classes
{
    public class ClownFish : Marine
    {
        /// <summary>
        /// Swimming methods from Fish and returning new string value.
        /// </summary>
        public override string Swimming()
        {
            return "Stop swimming dory!";
        }

    }
}
