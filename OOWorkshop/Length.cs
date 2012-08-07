using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOWorkshop
{
    public class Length
    {
        public static Length CreateLength(double number, int factor)
        {
//            return new Length(number,factor);
            if (factor == 100)
                return new Length(number, Unit.Meter);
            if (factor == 10)
                return new Length(number, Unit.Decimeter);
            return new Length(number, Unit.Centimeter);
        }

        private Length(double number, Unit unit)
        {
            Number = number;
            Unit = unit;
        }

        protected Unit Unit { get; private set; }

//        private Length(double number, int factor)
//        {
//            Number = number;
//            Factor = factor;
//        }

        public double Number { get; protected set; }
//        public double Factor { get; protected set; }

        public double ConvertToCM()
        {
            return Number*(double) Unit;
        }

        public static Length operator +(Length length1, Length length2)
        {
            return CreateLength((length1.ConvertToCM() + length2.ConvertToCM()), 1);
        }

        public static Length operator -(Length length1, Length length2)
        {
            var length1ToCM = length1.ConvertToCM();
            var length2ToCM = length2.ConvertToCM();
            if (length1ToCM - length2ToCM < 0) throw new NegativeValueException();
            return CreateLength(length1ToCM - length2ToCM, 1);
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