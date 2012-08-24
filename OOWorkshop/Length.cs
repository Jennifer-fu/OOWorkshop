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

        public static Length operator +(Length length1, Length length2)
        {
            return new Length(length1.ToBaseUnit() + length2.ToBaseUnit(), Unit.Millimeter);
        }

        public static Length operator -(Length length1, Length length2)
        {
            double number = length1.ToBaseUnit() - length2.ToBaseUnit();
            if (number < 0) throw new NegativeValueException();
            return new Length(number, Unit.Millimeter);
        }

        public override bool Equals(object obj)
        {
            var length = (obj as Length);
            return IsEqual(length.ToBaseUnit(), ToBaseUnit());
        }

        public override int GetHashCode()
        {
            return ToBaseUnit().GetHashCode();
        }

        private Unit Unit { get; set; }

        private double Number { get; set; }

        private double ToBaseUnit()
        {
            double factor = (int) Unit;
            if (Unit == Unit.Inch) 
                factor = 25.4;
            return Number*factor;
        }

        private bool IsEqual(double d1, double d2)
        {
            return Math.Abs(d1 - d2) <= 0.000001;
        }
    }
}