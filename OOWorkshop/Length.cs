using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOWorkshop
{
    public abstract class Length
    {
        protected Length(double number, int factor)
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
            if (length1 is Meter)
                return new Meter((length1.ConvertToCM() + length2.ConvertToCM())/length1.Factor);
            if (length1 is Decimeter)
                return new Decimeter((length1.ConvertToCM() + length2.ConvertToCM())/length1.Factor);
            return new Centimeter((length1.ConvertToCM() + length2.ConvertToCM())/length1.Factor);
        }


        public static Length operator -(Length m1, Length m2)
        {
            if (m1.Number - m2.Number < 0) throw new NegativeValueException();
            return new Meter(m1.Number - m2.Number);
        }

        public override bool Equals(object obj)
        {
            if (obj is Decimeter)
                return IsEqual((obj as Decimeter).ConvertToCM(), ConvertToCM());
            if (obj is Meter)
                return IsEqual((obj as Meter).ConvertToCM(), ConvertToCM());
            return IsEqual((obj as Centimeter).ConvertToCM(), ConvertToCM());
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