﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOWorkshop
{
    public class Decimeter : Length
    {
        public Decimeter(double number)
        {
            Number = number;
        }

        public override int Factor()
        {
            return 10;
        }

        public static Decimeter operator +(Decimeter dm, Length length)
        {
            return new Decimeter((dm.ConvertToCM() + length.ConvertToCM()) / dm.Factor());
        }
    }
}