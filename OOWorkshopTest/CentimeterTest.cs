using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OOWorkshop;

namespace OOWorkshopTest
{
    [TestFixture]
    class CentimeterTest
    {
        private Length oneCM;

        [TestFixtureSetUp]
        public void Setup()
        {
            oneCM = new Length(1, Unit.Centimeter);
        }

        [Test]
        public void should_equal_2cm_given_1cm_plus_1cm()
        {
            (oneCM + oneCM).should_be(new Length(2, Unit.Centimeter));
        }

        [Test]
        public void should_equal_11_centimeters_given_1_centimeter_and_1_decimeter()
        {
            var oneDM = new Length(1, Unit.Decimeter);
            (oneCM + oneDM).should_be(new Length(11, Unit.Centimeter));
        }

        [Test]
        public void should_equal_101_centimeters_given_1_centimeter_and_1_meter()
        {
            var oneM = new Length(1, Unit.Meter);
            (oneCM + oneM).should_be(new Length(101, Unit.Centimeter));
        }
    }
}
