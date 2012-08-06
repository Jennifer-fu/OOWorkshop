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

        public static Meter operator +(Meter m1, Length length)
        {
            return new Meter((m1.ConvertToCM()+ length.ConvertToCM())/m1.Factor());
        }

        public static Meter operator -(Meter m1, Meter m2)
        {
            if (m1.Number - m2.Number < 0) throw new NegativeValueException();
            return new Meter(m1.Number - m2.Number);
        }

        public override bool Equals(object obj)
        {
            if (obj is Decimeter) 
                return IsEqual((obj as Decimeter).ConvertToCM(),ConvertToCM());
            if (obj is Meter) 
                return IsEqual((obj as Meter).ConvertToCM(),ConvertToCM());
            return false;
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