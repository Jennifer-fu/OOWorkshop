using NUnit.Framework;
using OOWorkshop;

namespace OOWorkshopTest
{
    [TestFixture]
    public class MillimeterTest
    {
        [Test]
        public void should_equal_2mm_given_1mm_plus_1mm()
        {
            var oneMM = new Length(1, Unit.Millimeter);
            var twoMMs = new Length(2, Unit.Millimeter);
            (oneMM + oneMM).should_be(twoMMs);
        }

        [Test]
        public void should_equal_11mm_given_1mm_plus_1cm()
        {
            var oneMM = new Length(1, Unit.Millimeter);
            var oneCM = new Length(1, Unit.Centimeter);
            (oneMM + oneCM).should_be(new Length(11, Unit.Millimeter));
        }

        [Test]
        public void should_equal_1_point_1cm_given_1mm_plus_1cm()
        {
            var oneMM = new Length(1, Unit.Millimeter);
            var oneCM = new Length(1, Unit.Centimeter);
            (oneMM + oneCM).should_be(new Length(1.1, Unit.Centimeter));
        }

        [Test]
        public void should_equal_1_point_1dm_given_1mm_plus_1dm()
        {
            var oneMM = new Length(1, Unit.Millimeter);
            var oneDM = new Length(1, Unit.Decimeter);
            (oneMM + oneDM).should_be(new Length(1.01, Unit.Decimeter));
        }

        [Test]
        public void should_equal_101_mm_given_1mm_plus_1dm()
        {
            var oneMM = new Length(1, Unit.Millimeter);
            var oneDM = new Length(1, Unit.Decimeter);
            (oneMM + oneDM).should_be(new Length(101, Unit.Millimeter));
        }

        [Test]
        public void should_equal_1001_mm_given_1mm_plus_1m()
        {
            var oneMM = new Length(1, Unit.Millimeter);
            var oneM = new Length(1, Unit.Meter);
            (oneMM + oneM).should_be(new Length(1001, Unit.Millimeter));
        }

        [Test]
        public void should_equal_1_point_001_mm_given_1mm_plus_1m()
        {
            var oneMM = new Length(1, Unit.Millimeter);
            var oneM = new Length(1, Unit.Meter);
            (oneMM + oneM).should_be(new Length(1.001, Unit.Meter));
        }
    }
}