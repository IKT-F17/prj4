using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonstersMapsTowers.Interfaces;
using MonstersMapsTowers.Class;
using NSubstitute;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace ClassLibrary1
{
    public class DefensiveUnitUtillitiesUnitTest
    {
        DefensiveUnitUtilities _uut;
        IPlayer fakePlayer;
        IDefensiveUnit fakeDefensiveUnit;

        [SetUp]
        public void Setup()
        {
            _uut = new DefensiveUnitUtilities();
            fakePlayer = Substitute.For<IPlayer>();
            fakeDefensiveUnit = Substitute.For<IDefensiveUnit>();
        }

        [Test]
        public void TestUpgradeDefensiveUnit()
        {
            fakePlayer.bank = 100;
            fakeDefensiveUnit.defensiveLevel = 1;
            fakeDefensiveUnit.nameDefensiveUnit = "DefensiveUnit";
            fakeDefensiveUnit.defensivePower = 20;
            fakeDefensiveUnit.defenseType = 1;
            fakeDefensiveUnit.defenseRange = 1;
            fakeDefensiveUnit.upgradeCost = 20;
            fakeDefensiveUnit.defensiveTiles = 1;
            
            _uut.UpgradeUnit(ref fakeDefensiveUnit, fakePlayer);//goblinkiller eller IDefensiveUnit

            Assert.That(fakeDefensiveUnit.defensiveLevel, Is.EqualTo(2));
           Assert.That(fakeDefensiveUnit.nameDefensiveUnit, Is.EqualTo("DefensiveUnit Level 2"));
            Assert.That(fakeDefensiveUnit.defensivePower, Is.EqualTo(22));
            Assert.That(fakeDefensiveUnit.defenseType, Is.EqualTo(1));
            Assert.That(fakeDefensiveUnit.defenseRange, Is.EqualTo(2));
            Assert.That(fakeDefensiveUnit.upgradeCost, Is.EqualTo(30));
            Assert.That(fakeDefensiveUnit.unitValue, Is.EqualTo(30));

           Assert.That(fakeDefensiveUnit.defensiveTiles, Is.EqualTo(1));
          // Assert.That(fakePlayer.bank,Is.EqualTo(80)); 
        }

        [Test]
        public void TestDowngradeDefensiveUnit()
        {
            fakePlayer.bank = 1000;
            fakeDefensiveUnit.defensiveLevel = 2;
            fakeDefensiveUnit.nameDefensiveUnit = "DefensiveUnit Level 2";
            fakeDefensiveUnit.defensivePower = 20;
            fakeDefensiveUnit.defenseType = 1;
            fakeDefensiveUnit.defenseRange = 2;
            fakeDefensiveUnit.upgradeCost = 30;
            fakeDefensiveUnit.defensiveTiles = 1;
            fakeDefensiveUnit.unitValue = 30;

            _uut.DowngradeUnit(ref fakeDefensiveUnit, fakePlayer);//goblinkiller eller IDefensiveUnit

            Assert.That(fakeDefensiveUnit.defensiveLevel, Is.EqualTo(1));
            // Assert.That(fakeDefensiveUnit.nameDefensiveUnit, Is.EqualTo("DefensiveUnit Level 2 Level 1"));
            Assert.That(fakeDefensiveUnit.defensivePower, Is.EqualTo(18));
            Assert.That(fakeDefensiveUnit.defenseType, Is.EqualTo(1));
            Assert.That(fakeDefensiveUnit.defenseRange, Is.EqualTo(1));
            Assert.That(fakeDefensiveUnit.upgradeCost, Is.EqualTo(20));
           Assert.That(fakeDefensiveUnit.unitValue, Is.EqualTo(15));// vil blive 0 ? 20 + (-20)

            Assert.That(fakeDefensiveUnit.defensiveTiles, Is.EqualTo(1));
        }
    }
}
