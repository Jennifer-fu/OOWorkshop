using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OOWorkshop;

namespace OOWorkshopTest
{
    [TestFixture]
    public class MeterTest
    {
        private Length oneMeter;
        private Length twoMeters;
        private Length threeMeters;

        [TestFixtureSetUp]
        public void setUp()
        {
            oneMeter = new Length(1, Unit.Meter);
            twoMeters = new Length(2, Unit.Meter);
            threeMeters = new Length(3, Unit.Meter);
        }

        [Test]
        public void should_equal_2m_given_1m_plus_1m()
        {
            (oneMeter + oneMeter).should_be(twoMeters);
        }

        [Test]
        public void should_not_equal_2m_given_3m_plus_1m()
        {
            (threeMeters + oneMeter).should_not_be(twoMeters);
        }

        [Test]
        public void should_equal_1m_given_2m_minus_1m()
        {
            (twoMeters - oneMeter).should_be(oneMeter);
        }

        [Test]
        public void should_not_equal_1m_given_3m_minus_1m()
        {
            (threeMeters - oneMeter).should_not_be(oneMeter);
        }

        [Test]
        [ExpectedException(typeof(NegativeValueException))]
        public void should_throw_exception_given_1m_minius_3m()
        {
            var meaningless = oneMeter - threeMeters;
        }
    }
}