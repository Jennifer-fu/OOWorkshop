using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOWorkshop
{
   
    public abstract class Length
    {
        public double Number { get; protected set; }

        public abstract int Factor();

        public double ConvertToCM()
        {
            return Number * Factor();
        }

        public override bool Equals(object obj)
        {
            if (obj is Decimeter) 
                return IsEqual((obj as Decimeter).ConvertToCM(),ConvertToCM());
            if (obj is Meter) 
                return IsEqual((obj as Meter).ConvertToCM(),ConvertToCM());
            return IsEqual((obj as Centimeter).ConvertToCM(),ConvertToCM());
        }

        public bool IsEqual(double d1, double d2)
        {
            return Math.Abs(d1 - d2) <= 0.000001;
        }

        public override int GetHashCode()
        {
            return Number.GetHashCode();
        }
    }
}
