using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    interface IDisc
    {
        void SpinDisc();
        string Read();
        string OnLoad();
    }
}
