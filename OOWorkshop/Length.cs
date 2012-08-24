using System;

namespace OOWorkshop
{
    public class Length
    {
        private readonly double number;
        private readonly Unit unit;

        public Length(double number, Unit unit)
        {
            this.number = number;
            this.unit = unit;
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
            return IsEqual((obj as Length).ToBaseUnit(), ToBaseUnit());
        }

        public override int GetHashCode()
        {
            return ToBaseUnit().GetHashCode();
        }

        private double ToBaseUnit()
        {
            return number*unit.Factor;
        }

        private bool IsEqual(double d1, double d2)
        {
            return Math.Abs(d1 - d2) <= 0.000001;
        }
    }
}