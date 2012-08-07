using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OOWorkshop;

namespace OOWorkshopTest
{
    [TestFixture]
    class DecimeterTest
    {
        private Length oneDM;
        private Length oneM;
        private Length twoDMs;

        [TestFixtureSetUp]
        public void Setup()
        {
            oneDM = new Length(1,10);
            oneM = new Length(1,100);
            twoDMs = new Length(2,10);
        }

        [Test]
        public void should_equal_2dm_given_1dm_plus_1dm()
        {
            (oneDM + oneDM).should_be(new Length(2,10));
        }

        [Test]
        public void should_equal_11dm_given_1m_plus_1dm()
        {
            (oneDM + oneM).should_be(new Length(11,10));
        }

        [Test]
        public void should_not_equal_11dm_given_1m_plus_2dm()
        {
            (twoDMs + oneM).should_not_be(new Length(11,10));
        }

        [Test]
        public void should_equal_1_point_1_meter_given_1m_plus_10dm()
        {
            var tenDMs = new Length(10,10);
            (tenDMs + oneM).should_be(new Length(2,100));
        }

        [Test]
        public void should_equal_1_point_1_meters_given_1m_plus_1dm()
        {
            (oneDM + oneM).should_be(new Length(1.1,100));
        }
    }
}
