﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonstersMapsTowers.Interfaces;
using MonstersMapsTowers.Class;
using MonstersMapsTowers.Class.DefensiveUnits;
using NSubstitute;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace ClassLibrary1
{
    public class DefensiveUnitUtillitiesUnitTest
    {
        DefensiveUnitUtilities _uut;
        Player fakePlayer;
        ArcherTower fakeDefensiveUnit;
        //private string user_="IB";
        private CannonTower fakeDefensiveUnit1;

        [SetUp]
        public void Setup()
        {
          //  var username=new Player("");
            _uut = new DefensiveUnitUtilities();
            fakePlayer = Substitute.For<Player>("IB");
            fakeDefensiveUnit = Substitute.For<ArcherTower>();
            fakeDefensiveUnit1 = Substitute.For<CannonTower>();
            }

        [Test]
        public void TestUpgradeDefensiveUnit_ArcherTower()
        {
            fakePlayer.bank = 100;
            fakeDefensiveUnit.defensiveLevel = 1;
            fakeDefensiveUnit.nameDefensiveUnit = "ArcherTower";
            fakeDefensiveUnit.defensivePower = 20;
            fakeDefensiveUnit.defenseType = 1;
            fakeDefensiveUnit.defenseRange = 1;
            fakeDefensiveUnit.upgradeCost = 20;
            fakeDefensiveUnit.unitValue = 20;
          
            _uut.UpgradeUnit(ref fakeDefensiveUnit, ref fakePlayer);//goblinkiller eller IDefensiveUnit

            Assert.That(fakeDefensiveUnit.defensiveLevel, Is.EqualTo(2));
            Assert.That(fakeDefensiveUnit.nameDefensiveUnit, Is.EqualTo("ArcherTower Level 2"));
            Assert.That(fakeDefensiveUnit.defensivePower, Is.EqualTo(22));
            Assert.That(fakeDefensiveUnit.defenseType, Is.EqualTo(1));
            Assert.That(fakeDefensiveUnit.defenseRange, Is.EqualTo(2));
            Assert.That(fakeDefensiveUnit.upgradeCost, Is.EqualTo(30));
            Assert.That(fakeDefensiveUnit.unitValue, Is.EqualTo(40));

            Assert.That(fakePlayer.bank, Is.EqualTo(80));
        }
        [Test]
        public void TestUpgradeDefensiveUnit_ArcherTower_TooExpensiveUnit()
        {
            fakePlayer.bank = 10;
            fakeDefensiveUnit.defensiveLevel = 1;
            fakeDefensiveUnit.nameDefensiveUnit = "ArcherTower";
            fakeDefensiveUnit.defensivePower = 20;
            fakeDefensiveUnit.defenseType = 1;
            fakeDefensiveUnit.defenseRange = 1;
            fakeDefensiveUnit.upgradeCost = 20;
            fakeDefensiveUnit.unitValue = 20;

            _uut.UpgradeUnit(ref fakeDefensiveUnit, ref fakePlayer);//goblinkiller eller IDefensiveUnit

            Assert.That(fakeDefensiveUnit.defensiveLevel, Is.EqualTo(1));
            Assert.That(fakeDefensiveUnit.nameDefensiveUnit, Is.EqualTo("ArcherTower"));
            Assert.That(fakeDefensiveUnit.defensivePower, Is.EqualTo(20));
            Assert.That(fakeDefensiveUnit.defenseType, Is.EqualTo(1));
            Assert.That(fakeDefensiveUnit.defenseRange, Is.EqualTo(1));
            Assert.That(fakeDefensiveUnit.upgradeCost, Is.EqualTo(20));
            Assert.That(fakeDefensiveUnit.unitValue, Is.EqualTo(20));

            Assert.That(fakePlayer.bank, Is.EqualTo(10));
        }
        [Test]
        public void TestDowngradeDefensiveUnit_ArcherTower()
        {
            fakePlayer.bank = 100;
            fakeDefensiveUnit.defensiveLevel = 2;
            fakeDefensiveUnit.nameDefensiveUnit = "ArcherTower Level 2";
            fakeDefensiveUnit.defensivePower = 20;
            fakeDefensiveUnit.defenseType = 1;
            fakeDefensiveUnit.defenseRange = 2;
            fakeDefensiveUnit.upgradeCost = 30;
           fakeDefensiveUnit.unitValue = 30;

            _uut.DowngradeUnit(ref fakeDefensiveUnit, ref fakePlayer);

            Assert.That(fakeDefensiveUnit.defensiveLevel, Is.EqualTo(1));
            Assert.That(fakeDefensiveUnit.nameDefensiveUnit, Is.EqualTo("ArcherTower Level 1"));
            Assert.That(fakeDefensiveUnit.defensivePower, Is.EqualTo(18));
            Assert.That(fakeDefensiveUnit.defenseType, Is.EqualTo(1));
            Assert.That(fakeDefensiveUnit.defenseRange, Is.EqualTo(1));
            Assert.That(fakeDefensiveUnit.upgradeCost, Is.EqualTo(20));
            Assert.That(fakeDefensiveUnit.unitValue, Is.EqualTo(15));

           Assert.That(fakePlayer.bank, Is.EqualTo(130));
        }
        [Test]
        public void TestDowngradeDefensiveUnit_ArcherTower_TowerLevel1()
        {
            fakePlayer.bank = 100;
            fakeDefensiveUnit.defensiveLevel = 1;
            fakeDefensiveUnit.nameDefensiveUnit = "ArcherTower Level 1";
            fakeDefensiveUnit.defensivePower = 20;
            fakeDefensiveUnit.defenseType = 1;
            fakeDefensiveUnit.defenseRange = 2;
            fakeDefensiveUnit.upgradeCost = 30;

            fakeDefensiveUnit.unitValue = 30;

            _uut.DowngradeUnit(ref fakeDefensiveUnit, ref fakePlayer);

            Assert.That(fakeDefensiveUnit.defensiveLevel, Is.EqualTo(1));
            Assert.That(fakeDefensiveUnit.nameDefensiveUnit, Is.EqualTo("ArcherTower Level 1"));
            Assert.That(fakeDefensiveUnit.defensivePower, Is.EqualTo(20));
            Assert.That(fakeDefensiveUnit.defenseType, Is.EqualTo(1));
            Assert.That(fakeDefensiveUnit.defenseRange, Is.EqualTo(2));
            Assert.That(fakeDefensiveUnit.upgradeCost, Is.EqualTo(30));
            Assert.That(fakeDefensiveUnit.unitValue, Is.EqualTo(30));

            Assert.That(fakePlayer.bank, Is.EqualTo(100));
        }
        [Test]
        public void TestUpgradeDefensiveUnit_CannonTower()
        {
            fakePlayer.bank = 100;
            fakeDefensiveUnit1.defensiveLevel = 1;
            fakeDefensiveUnit1.nameDefensiveUnit = "CannonTower";
            fakeDefensiveUnit1.defensivePower = 20;
            fakeDefensiveUnit1.defenseType = 1;
            fakeDefensiveUnit1.defenseRange = 1;
            fakeDefensiveUnit1.upgradeCost = 20;
            fakeDefensiveUnit1.unitValue = 20;

            _uut.UpgradeUnit(ref fakeDefensiveUnit1, ref fakePlayer);//goblinkiller eller IDefensiveUnit

            Assert.That(fakeDefensiveUnit1.defensiveLevel, Is.EqualTo(2));
            Assert.That(fakeDefensiveUnit1.nameDefensiveUnit, Is.EqualTo("CannonTower Level 2"));
            Assert.That(fakeDefensiveUnit1.defensivePower, Is.EqualTo(22));
            Assert.That(fakeDefensiveUnit1.defenseType, Is.EqualTo(1));
            Assert.That(fakeDefensiveUnit1.defenseRange, Is.EqualTo(2));
            Assert.That(fakeDefensiveUnit1.upgradeCost, Is.EqualTo(30));
            Assert.That(fakeDefensiveUnit1.unitValue, Is.EqualTo(40));

            Assert.That(fakePlayer.bank, Is.EqualTo(80));
        }
        [Test]
        public void TestDowngradeDefensiveUnit_CannonTower()
        {
            fakePlayer.bank = 100;
            fakeDefensiveUnit1.defensiveLevel = 2;
            fakeDefensiveUnit1.nameDefensiveUnit = "CannonTower Level 2";
            fakeDefensiveUnit1.defensivePower = 20;
            fakeDefensiveUnit1.defenseType = 1;
            fakeDefensiveUnit1.defenseRange = 2;
            fakeDefensiveUnit1.upgradeCost = 30;
           fakeDefensiveUnit1.unitValue = 30;

            _uut.DowngradeUnit(ref fakeDefensiveUnit1, ref fakePlayer);//goblinkiller eller IDefensiveUnit

            Assert.That(fakeDefensiveUnit1.defensiveLevel, Is.EqualTo(1));
             Assert.That(fakeDefensiveUnit1.nameDefensiveUnit, Is.EqualTo("CannonTower Level 1"));
            Assert.That(fakeDefensiveUnit1.defensivePower, Is.EqualTo(18));
            Assert.That(fakeDefensiveUnit1.defenseType, Is.EqualTo(1));
            Assert.That(fakeDefensiveUnit1.defenseRange, Is.EqualTo(1));
            Assert.That(fakeDefensiveUnit1.upgradeCost, Is.EqualTo(20));
            Assert.That(fakeDefensiveUnit1.unitValue, Is.EqualTo(15));

           

            Assert.That(fakePlayer.bank, Is.EqualTo(130));
        }
        [Test]
        public void TestDowngradeDefensiveUnit_CannonTower_TowerLevel1()
        {
            fakePlayer.bank = 100;
            fakeDefensiveUnit1.defensiveLevel = 1;
            fakeDefensiveUnit1.nameDefensiveUnit = "CannonTower Level 1";
            fakeDefensiveUnit1.defensivePower = 20;
            fakeDefensiveUnit1.defenseType = 1;
            fakeDefensiveUnit1.defenseRange = 2;
            fakeDefensiveUnit1.upgradeCost = 30;
           
            fakeDefensiveUnit1.unitValue = 30;

            _uut.DowngradeUnit(ref fakeDefensiveUnit1, ref fakePlayer);

            Assert.That(fakeDefensiveUnit1.defensiveLevel, Is.EqualTo(1));
            Assert.That(fakeDefensiveUnit1.nameDefensiveUnit, Is.EqualTo("CannonTower Level 1"));
            Assert.That(fakeDefensiveUnit1.defensivePower, Is.EqualTo(20));
            Assert.That(fakeDefensiveUnit1.defenseType, Is.EqualTo(1));
            Assert.That(fakeDefensiveUnit1.defenseRange, Is.EqualTo(2));
            Assert.That(fakeDefensiveUnit1.upgradeCost, Is.EqualTo(30));
            Assert.That(fakeDefensiveUnit1.unitValue, Is.EqualTo(30));

           Assert.That(fakePlayer.bank, Is.EqualTo(100));
        }
        [Test]
        public void TestUpgradeDefensiveUnit_CannonTower_TooExpensiveUnit()
        {
            fakePlayer.bank = 10;
            fakeDefensiveUnit1.defensiveLevel = 1;
            fakeDefensiveUnit1.nameDefensiveUnit = "CannonTower";
            fakeDefensiveUnit1.defensivePower = 20;
            fakeDefensiveUnit1.defenseType = 1;
            fakeDefensiveUnit1.defenseRange = 1;
            fakeDefensiveUnit1.upgradeCost = 20;
            fakeDefensiveUnit1.unitValue = 20;

            _uut.UpgradeUnit(ref fakeDefensiveUnit1, ref fakePlayer);//goblinkiller eller IDefensiveUnit

            Assert.That(fakeDefensiveUnit1.defensiveLevel, Is.EqualTo(1));
            Assert.That(fakeDefensiveUnit1.nameDefensiveUnit, Is.EqualTo("CannonTower"));
            Assert.That(fakeDefensiveUnit1.defensivePower, Is.EqualTo(20));
            Assert.That(fakeDefensiveUnit1.defenseType, Is.EqualTo(1));
            Assert.That(fakeDefensiveUnit1.defenseRange, Is.EqualTo(1));
            Assert.That(fakeDefensiveUnit1.upgradeCost, Is.EqualTo(20));
            Assert.That(fakeDefensiveUnit1.unitValue, Is.EqualTo(20));

            Assert.That(fakePlayer.bank, Is.EqualTo(10));
        }
    }
}
