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
    [TestFixture]
    public class GoblinKillerUnitTest
    {
        ArcherTower _uut;
        

        

        [SetUp]
        public void Setup()
        {
            _uut = new ArcherTower(1);
        }

        [Test]
        public void TestGoblinKillerConstrucer()
        {
            Assert.That(_uut.nameDefensiveUnit, Is.EqualTo("ArcherTower"));
            Assert.That(_uut.defensivePower, Is.EqualTo(20));
            Assert.That(_uut.defenseType, Is.EqualTo(1));
            Assert.That(_uut.defenseRange, Is.EqualTo(1));
            Assert.That(_uut.upgradeCost, Is.EqualTo(-20));
            Assert.That(_uut.unitValue, Is.EqualTo(20));
            Assert.That(_uut.defensiveTiles, Is.EqualTo(1));
            Assert.That(_uut.defensiveLevel, Is.EqualTo(1));
            Assert.That(_uut.unitCost, Is.EqualTo(20));
            Assert.That(_uut.unitValue, Is.EqualTo(20));
        }

       

    }
}
