using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOWorkshop
{
    public class Length
    {
        public Length(double number, int factor)
        {
            Number = number;
            Factor = factor;
        }

        public double Number { get; protected set; }
        public double Factor { get; protected set; }

        public double ConvertToCM()
        {
            return Number*Factor;
        }

        public static Length operator +(Length length1, Length length2)
        {
            return new Length((length1.ConvertToCM() + length2.ConvertToCM()),1);
        }

        public static Length operator -(Length m1, Length m2)
        {
            if (m1.Number - m2.Number < 0) throw new NegativeValueException();
            return new Length(m1.Number - m2.Number,100);
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