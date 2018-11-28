using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonstersMapsTowers.Class.DefensiveUnits;
using MonstersMapsTowers.Interfaces;
using NSubstitute;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace ClassLibrary1.DefensiveUnits
{
    class PonyKillerUnitTest
    {
        private PonyKiller _uut;

        [SetUp]
        public void Setup()
        {
            _uut=new PonyKiller(1);
        }

        [Test]
        public void TestPonyKillerConstrucer()
        {
            Assert.That(_uut.nameDefensiveUnit, Is.EqualTo("PonyKiller"));
            Assert.That(_uut.defensivePower, Is.EqualTo(30));
            Assert.That(_uut.defenseType, Is.EqualTo(2));
            Assert.That(_uut.defenseRange, Is.EqualTo(1));
            Assert.That(_uut.upgradeCost, Is.EqualTo(-40));
            Assert.That(_uut.unitValue, Is.EqualTo(40));
            Assert.That(_uut.defensiveTiles, Is.EqualTo(1));
            Assert.That(_uut.defensiveLevel, Is.EqualTo(1));
            Assert.That(_uut.unitCost, Is.EqualTo(-50));
        }
    }
}
