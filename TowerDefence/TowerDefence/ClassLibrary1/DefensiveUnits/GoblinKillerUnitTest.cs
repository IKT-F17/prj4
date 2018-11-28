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
        GoblinKiller _uut;
        

        

        [SetUp]
        public void Setup()
        {
            _uut = new GoblinKiller(1);
        }

        [Test]
        public void TestGoblinKillerConstrucer()
        {
            Assert.That(_uut.nameDefensiveUnit, Is.EqualTo("GoblinKiller"));
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

        //[Test]
        //public void TestUpgradeGoblinKiller()
        //{
        //    //GoblinKiller test = new GoblinKiller(2);

        //   // _uut.upgradUnit(ref _uut, fakePlayer);//goblinkiller eller IDefensiveUnit


        //  //  Assert.That(_uut.defensiveLevel, Is.EqualTo(2));
        //    //// Assert.That(_uut.nameDefensiveUnit, Is.EqualTo("GoblinKiller Level 2"));
        //    //// Assert.That(_uut.defensivePower, Is.EqualTo(22));
        //    //// Assert.That(_uut.defenseType, Is.EqualTo(1));
        //    // //Assert.That(_uut.defenseRange, Is.EqualTo(2));
        //    // //Assert.That(_uut.upgradeCost, Is.EqualTo(-30));
        //    //// Assert.That(_uut.unitValue, Is.EqualTo(20)); vil blive 0? 20+(-20)
        //    // Assert.That(_uut.defensiveTiles, Is.EqualTo(1));

        //    // //Assert.That(_uut.unitCost, Is.EqualTo(-20)); har vi ikke med i upgrade
        //}

        //[Test]
        //public void TestDowngradeGoblinKiller()
        //{ }

    }
}
