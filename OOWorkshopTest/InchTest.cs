using NUnit.Framework;
using OOWorkshop;

namespace OOWorkshopTest
{
    [TestFixture]
    public class InchTest
    {
        [Test]
        public void should_equal_2_inch_given_1_inch_add_1_inch()
        {
            var oneInch = new Length(1, Unit.Inch);
            (oneInch + oneInch).should_be(new Length(2, Unit.Inch));
        }

        [Test]
        public void should_equal_1_point_0254_meter_given_one_meter_add_one_inch()
        {
            var oneInch = new Length(1, Unit.Inch);
            var oneMeter = new Length(1, Unit.Meter);
            (oneMeter + oneInch).should_be(new Length(1.0254, Unit.Meter));
        }
    }
}