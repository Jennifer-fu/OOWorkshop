namespace OOWorkshop
{
    public class Unit
    {
        public static Unit Meter = new Unit(1000);
        public static Unit Decimeter = new Unit(100);
        public static Unit Centimeter = new Unit(10);
        public static Unit Millimeter = new Unit(1);
        public static Unit Inch = new Unit(25.4);


        private Unit(double factor)
        {
            Factor = factor;
        }

        public double Factor { get; private set; }
    }
}