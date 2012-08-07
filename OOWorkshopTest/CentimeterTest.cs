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
            oneCM = Length.CreateLength(1,1);
        }

        [Test]
        public void should_equal_2cm_given_1cm_plus_1cm()
        {
            (oneCM + oneCM).should_be(Length.CreateLength(2,1));
        }

        [Test]
        public void should_equal_11_centimeters_given_1_centimeter_and_1_decimeter()
        {
            var oneDM = Length.CreateLength(1,10);
            (oneCM + oneDM).should_be(Length.CreateLength(11,1));
        }

        [Test]
        public void should_equal_101_centimeters_given_1_centimeter_and_1_meter()
        {
            var oneM = Length.CreateLength(1,100);
            (oneCM + oneM).should_be(Length.CreateLength(101,1));
        }
    }
}
