using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOWorkshop
{
    public class Meter : Length
    {
        private Meter(double number):base(number,100)
        {
        }
    }
}