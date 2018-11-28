//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MonstersMapsTowers.Interfaces;
//using MonstersMapsTowers.Class;
//using NSubstitute;
//using NUnit.Framework;
//using NUnit.Framework.Internal;

//namespace ClassLibrary1
//{
//    public class DefensiveUnitUtillitiesUnitTest
//    {
//        DefensiveUnitUtilities _uut;
//        IPlayer fakePlayer;
//        IDefensiveUnit fakeDefensiveUnit;

//        [SetUp]
//        public void Setup()
//        {
//            _uut = new DefensiveUnitUtilities();
//            fakePlayer = Substitute.For<IPlayer>();
//            fakeDefensiveUnit = Substitute.For<IDefensiveUnit>();
//        }

//        [Test]
//        public void TestUpgradeGoblinKiller()
//        {
//            _uut.UpgradeUnit(ref fakeDefensiveUnit, fakePlayer);//goblinkiller eller IDefensiveUnit

//            Assert.That(fakeDefensiveUnit.defensiveLevel, Is.EqualTo(2));
//            Assert.That(fakeDefensiveUnit.nameDefensiveUnit, Is.EqualTo("GoblinKiller Level 2"));
//            Assert.That(fakeDefensiveUnit.defensivePower, Is.EqualTo(22));
//            Assert.That(fakeDefensiveUnit.defenseType, Is.EqualTo(1));
//            Assert.That(fakeDefensiveUnit.defenseRange, Is.EqualTo(2));
//            Assert.That(fakeDefensiveUnit.upgradeCost, Is.EqualTo(-30));
//            Assert.That(fakeDefensiveUnit.unitValue, Is.EqualTo(20)); vil blive 0 ? 20 + (-20)

//           Assert.That(fakeDefensiveUnit.defensiveTiles, Is.EqualTo(1));

//            Assert.That(_uut.unitCost, Is.EqualTo(-20)); har vi ikke med i upgrade
//        }

//        [Test]
//        public void TestDowngradeGoblinKiller()
//        { }
//    }
//}
