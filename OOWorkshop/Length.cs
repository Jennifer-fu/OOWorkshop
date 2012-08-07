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

        public double ToBaseUnit()
        {
            return Number*(double) Unit;
        }

        public static Length operator +(Length length1, Length length2)
        {
            double number = (length1.ToBaseUnit() + length2.ToBaseUnit());
            return new Length(number, Unit.Centimeter);
        }

        public static Length operator -(Length length1, Length length2)
        {
            var length1ToCM = length1.ToBaseUnit();
            var length2ToCM = length2.ToBaseUnit();
            double number = length1ToCM - length2ToCM;
            if (number < 0) throw new NegativeValueException();
            return new Length(number, Unit.Centimeter);
        }

        public override bool Equals(object obj)
        {
            var length = (obj as Length);
            return IsEqual(length.ToBaseUnit(), ToBaseUnit());
        }

        public bool IsEqual(double d1, double d2)
        {
            return Math.Abs(d1 - d2) <= 0.000001;
        }

        public override int GetHashCode()
        {
            return ToBaseUnit().GetHashCode();
        }
    }
}