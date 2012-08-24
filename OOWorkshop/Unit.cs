namespace OOWorkshop
{
//    public enum Unit
//    {
//        Meter = 1000,
//        Decimeter = 100,
//        Centimeter = 10,
//        Millimeter = 1,
//        Inch
//    }

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