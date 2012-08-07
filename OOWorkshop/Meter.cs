using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOWorkshop
{
    public class Meter : Length
    {
        public Meter(double number)
        {
            Number = number;
        }

        public override int Factor()
        {
            return 100;
        }
    }
}