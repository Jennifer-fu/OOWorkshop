using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOWorkshop
{
    public class Length
    {
        public Length(double number, Unit unit)
        {
            Number = number;
            Unit = unit;
        }

        protected Unit Unit { get; private set; }

        public double Number { get; private set; }

        public double ConvertToCM()
        {
            return Number*(double) Unit;
        }

        public static Length operator +(Length length1, Length length2)
        {
            double number = (length1.ConvertToCM() + length2.ConvertToCM());
            return new Length(number, Unit.Centimeter);
        }

        public static Length operator -(Length length1, Length length2)
        {
            var length1ToCM = length1.ConvertToCM();
            var length2ToCM = length2.ConvertToCM();
            if (length1ToCM - length2ToCM < 0) throw new NegativeValueException();
            double number = length1ToCM - length2ToCM;
            return new Length(number, Unit.Centimeter);
        }

        public override bool Equals(object obj)
        {
            var length = (obj as Length);
            return IsEqual(length.ConvertToCM(), ConvertToCM());
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