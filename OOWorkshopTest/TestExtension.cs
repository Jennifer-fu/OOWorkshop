﻿using NUnit.Framework;
using OOWorkshop;

namespace OOWorkshopTest
{
    public static class TestExtension
    {
        public static void should_be(this Meter meter, Meter expectedMeter)
        {
            Assert.AreEqual(expectedMeter, meter);
        }

        public static void should_not_be(this Meter meter, Meter expectedMeter)
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

        public static void should_be(this Decimeter decimeter, Meter expectedMeter)
        {
            Assert.AreEqual(expectedMeter, decimeter);
        }
    }
}