using NUnit.Framework;
using OOWorkshop;

namespace OOWorkshopTest
{
    public static class TestExtension
    {
        public static void should_be(this Length meter, Length expectedMeter)
        {
            Assert.AreEqual(expectedMeter, meter);
        }

        public static void should_not_be(this Length meter, Length expectedMeter)
        {
            Assert.AreNotEqual(expectedMeter, meter);
        }

        public static void should_be(this Decimeter decimeter, Decimeter expectedDecimeter)
        {
            Assert.AreEqual(expectedDecimeter, decimeter);
        }

        public static void should_not_be(this Decimeter decimeter, Decimeter expectedDecimeter)
        {
            Assert.AreNotEqual(expectedDecimeter, decimeter);
        }

        public static void should_be(this Decimeter decimeter, Length expectedMeter)
        {
            Assert.AreEqual(expectedMeter, decimeter);
        }

   
        public static void should_be(this Length centimeter, Decimeter expectedDecimeter)
        {
            Assert.AreEqual(centimeter, expectedDecimeter);
        }
    }
}