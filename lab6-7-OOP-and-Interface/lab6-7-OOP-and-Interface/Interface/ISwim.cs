using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_7_OOP_and_Interface.Interface
{
    interface ISwim
    {
        public bool HasFin { get; set; }

        void WiggleTail();

        string SwimFast();

    }
}
