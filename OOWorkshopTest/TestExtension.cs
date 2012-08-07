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
    }
}