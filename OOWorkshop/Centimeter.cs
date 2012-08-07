using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOWorkshop
{
    public class Centimeter : Length
    {
        public Centimeter(double number)
        {
            Number = number;
        }

        public override int Factor()
        {
            return 1;
        }

        public static Centimeter operator +(Centimeter cm, Length length)
        {
            return new Centimeter((cm.ConvertToCM() + length.ConvertToCM())/cm.Factor());
        }
    }
}