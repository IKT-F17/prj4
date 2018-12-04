using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonstersMapsTowers.Class;
using MonstersMapsTowers.Class.DefensiveUnits;
using NSubstitute;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace TowerDefence.Integration.Test
{
    [TestFixture]
    public class IntegrationTestStep2
    {
        DefensiveUnitUtilities DefUtilities;
        Player userPlayer;
        ArcherTower DefensiveUnitArcher;
        CannonTower DefensiveUnitCannon;

        [SetUp]
        public void Setup()
        {
            //  var username=new Player("");
            DefUtilities = new DefensiveUnitUtilities();
            userPlayer = new Player("IB");
            DefensiveUnitArcher = new ArcherTower();
            DefensiveUnitCannon = new CannonTower();
        }

        [Test]
        public void TestUpgradeDefensiveUnit_ArcherTower()
        {
            userPlayer.bank = 100;
            DefensiveUnitArcher.defensiveLevel = 1;
            DefensiveUnitArcher.nameDefensiveUnit = "ArcherTower";
            DefensiveUnitArcher.defensivePower = 20;
            DefensiveUnitArcher.defenseType = 1;
            DefensiveUnitArcher.defenseRange = 1;
            DefensiveUnitArcher.upgradeCost = 20;
            DefensiveUnitArcher.unitValue = 20;

            DefUtilities.UpgradeUnit(ref DefensiveUnitArcher, ref userPlayer);//goblinkiller eller IDefensiveUnit

            Assert.That(DefensiveUnitArcher.defensiveLevel, Is.EqualTo(2));
            Assert.That(DefensiveUnitArcher.nameDefensiveUnit, Is.EqualTo("ArcherTower Level 2"));
            Assert.That(DefensiveUnitArcher.defensivePower, Is.EqualTo(22));
            Assert.That(DefensiveUnitArcher.defenseType, Is.EqualTo(1));
            Assert.That(DefensiveUnitArcher.defenseRange, Is.EqualTo(2));
            Assert.That(DefensiveUnitArcher.upgradeCost, Is.EqualTo(30));
            Assert.That(DefensiveUnitArcher.unitValue, Is.EqualTo(40));

            Assert.That(userPlayer.bank, Is.EqualTo(80));
        }
        [Test]
        public void TestUpgradeDefensiveUnit_ArcherTower_TooExpensiveUnit()
        {
            userPlayer.bank = 10;
            DefensiveUnitArcher.defensiveLevel = 1;
            DefensiveUnitArcher.nameDefensiveUnit = "ArcherTower";
            DefensiveUnitArcher.defensivePower = 20;
            DefensiveUnitArcher.defenseType = 1;
            DefensiveUnitArcher.defenseRange = 1;
            DefensiveUnitArcher.upgradeCost = 20;
            DefensiveUnitArcher.unitValue = 20;

            DefUtilities.UpgradeUnit(ref DefensiveUnitArcher, ref userPlayer);//goblinkiller eller IDefensiveUnit

            Assert.That(DefensiveUnitArcher.defensiveLevel, Is.EqualTo(1));
            Assert.That(DefensiveUnitArcher.nameDefensiveUnit, Is.EqualTo("ArcherTower"));
            Assert.That(DefensiveUnitArcher.defensivePower, Is.EqualTo(20));
            Assert.That(DefensiveUnitArcher.defenseType, Is.EqualTo(1));
            Assert.That(DefensiveUnitArcher.defenseRange, Is.EqualTo(1));
            Assert.That(DefensiveUnitArcher.upgradeCost, Is.EqualTo(20));
            Assert.That(DefensiveUnitArcher.unitValue, Is.EqualTo(20));

            Assert.That(userPlayer.bank, Is.EqualTo(10));
        }
        [Test]
        public void TestDowngradeDefensiveUnit_ArcherTower()
        {
            userPlayer.bank = 100;
            DefensiveUnitArcher.defensiveLevel = 2;
            DefensiveUnitArcher.nameDefensiveUnit = "ArcherTower Level 2";
            DefensiveUnitArcher.defensivePower = 20;
            DefensiveUnitArcher.defenseType = 1;
            DefensiveUnitArcher.defenseRange = 2;
            DefensiveUnitArcher.upgradeCost = 30;
            DefensiveUnitArcher.unitValue = 30;

            DefUtilities.DowngradeUnit(ref DefensiveUnitArcher, ref userPlayer);

            Assert.That(DefensiveUnitArcher.defensiveLevel, Is.EqualTo(1));
            Assert.That(DefensiveUnitArcher.nameDefensiveUnit, Is.EqualTo("ArcherTower Level 1"));
            Assert.That(DefensiveUnitArcher.defensivePower, Is.EqualTo(18));
            Assert.That(DefensiveUnitArcher.defenseType, Is.EqualTo(1));
            Assert.That(DefensiveUnitArcher.defenseRange, Is.EqualTo(1));
            Assert.That(DefensiveUnitArcher.upgradeCost, Is.EqualTo(20));
            Assert.That(DefensiveUnitArcher.unitValue, Is.EqualTo(15));

            Assert.That(userPlayer.bank, Is.EqualTo(130));
        }
        [Test]
        public void TestDowngradeDefensiveUnit_ArcherTower_TowerLevel1()
        {
            userPlayer.bank = 100;
            DefensiveUnitArcher.defensiveLevel = 1;
            DefensiveUnitArcher.nameDefensiveUnit = "ArcherTower Level 1";
            DefensiveUnitArcher.defensivePower = 20;
            DefensiveUnitArcher.defenseType = 1;
            DefensiveUnitArcher.defenseRange = 2;
            DefensiveUnitArcher.upgradeCost = 30;

            DefensiveUnitArcher.unitValue = 30;

            DefUtilities.DowngradeUnit(ref DefensiveUnitArcher, ref userPlayer);

            Assert.That(DefensiveUnitArcher.defensiveLevel, Is.EqualTo(1));
            Assert.That(DefensiveUnitArcher.nameDefensiveUnit, Is.EqualTo("ArcherTower Level 1"));
            Assert.That(DefensiveUnitArcher.defensivePower, Is.EqualTo(20));
            Assert.That(DefensiveUnitArcher.defenseType, Is.EqualTo(1));
            Assert.That(DefensiveUnitArcher.defenseRange, Is.EqualTo(2));
            Assert.That(DefensiveUnitArcher.upgradeCost, Is.EqualTo(30));
            Assert.That(DefensiveUnitArcher.unitValue, Is.EqualTo(30));

            Assert.That(userPlayer.bank, Is.EqualTo(100));
        }
        [Test]
        public void TestUpgradeDefensiveUnit_CannonTower()
        {
            userPlayer.bank = 100;
            DefensiveUnitCannon.defensiveLevel = 1;
            DefensiveUnitCannon.nameDefensiveUnit = "CannonTower";
            DefensiveUnitCannon.defensivePower = 20;
            DefensiveUnitCannon.defenseType = 1;
            DefensiveUnitCannon.defenseRange = 1;
            DefensiveUnitCannon.upgradeCost = 20;
            DefensiveUnitCannon.unitValue = 20;

            DefUtilities.UpgradeUnit(ref DefensiveUnitCannon, ref userPlayer);//goblinkiller eller IDefensiveUnit

            Assert.That(DefensiveUnitCannon.defensiveLevel, Is.EqualTo(2));
            Assert.That(DefensiveUnitCannon.nameDefensiveUnit, Is.EqualTo("CannonTower Level 2"));
            Assert.That(DefensiveUnitCannon.defensivePower, Is.EqualTo(22));
            Assert.That(DefensiveUnitCannon.defenseType, Is.EqualTo(1));
            Assert.That(DefensiveUnitCannon.defenseRange, Is.EqualTo(2));
            Assert.That(DefensiveUnitCannon.upgradeCost, Is.EqualTo(30));
            Assert.That(DefensiveUnitCannon.unitValue, Is.EqualTo(40));

            Assert.That(userPlayer.bank, Is.EqualTo(80));
        }
        [Test]
        public void TestDowngradeDefensiveUnit_CannonTower()
        {
            userPlayer.bank = 100;
            DefensiveUnitCannon.defensiveLevel = 2;
            DefensiveUnitCannon.nameDefensiveUnit = "CannonTower Level 2";
            DefensiveUnitCannon.defensivePower = 20;
            DefensiveUnitCannon.defenseType = 1;
            DefensiveUnitCannon.defenseRange = 2;
            DefensiveUnitCannon.upgradeCost = 30;
            DefensiveUnitCannon.unitValue = 30;

            DefUtilities.DowngradeUnit(ref DefensiveUnitCannon, ref userPlayer);//goblinkiller eller IDefensiveUnit

            Assert.That(DefensiveUnitCannon.defensiveLevel, Is.EqualTo(1));
            Assert.That(DefensiveUnitCannon.nameDefensiveUnit, Is.EqualTo("CannonTower Level 1"));
            Assert.That(DefensiveUnitCannon.defensivePower, Is.EqualTo(18));
            Assert.That(DefensiveUnitCannon.defenseType, Is.EqualTo(1));
            Assert.That(DefensiveUnitCannon.defenseRange, Is.EqualTo(1));
            Assert.That(DefensiveUnitCannon.upgradeCost, Is.EqualTo(20));
            Assert.That(DefensiveUnitCannon.unitValue, Is.EqualTo(15));



            Assert.That(userPlayer.bank, Is.EqualTo(130));
        }
        [Test]
        public void TestDowngradeDefensiveUnit_CannonTower_TowerLevel1()
        {
            userPlayer.bank = 100;
            DefensiveUnitCannon.defensiveLevel = 1;
            DefensiveUnitCannon.nameDefensiveUnit = "CannonTower Level 1";
            DefensiveUnitCannon.defensivePower = 20;
            DefensiveUnitCannon.defenseType = 1;
            DefensiveUnitCannon.defenseRange = 2;
            DefensiveUnitCannon.upgradeCost = 30;

            DefensiveUnitCannon.unitValue = 30;

            DefUtilities.DowngradeUnit(ref DefensiveUnitCannon, ref userPlayer);

            Assert.That(DefensiveUnitCannon.defensiveLevel, Is.EqualTo(1));
            Assert.That(DefensiveUnitCannon.nameDefensiveUnit, Is.EqualTo("CannonTower Level 1"));
            Assert.That(DefensiveUnitCannon.defensivePower, Is.EqualTo(20));
            Assert.That(DefensiveUnitCannon.defenseType, Is.EqualTo(1));
            Assert.That(DefensiveUnitCannon.defenseRange, Is.EqualTo(2));
            Assert.That(DefensiveUnitCannon.upgradeCost, Is.EqualTo(30));
            Assert.That(DefensiveUnitCannon.unitValue, Is.EqualTo(30));

            Assert.That(userPlayer.bank, Is.EqualTo(100));
        }
        [Test]
        public void TestUpgradeDefensiveUnit_CannonTower_TooExpensiveUnit()
        {
            userPlayer.bank = 10;
            DefensiveUnitCannon.defensiveLevel = 1;
            DefensiveUnitCannon.nameDefensiveUnit = "CannonTower";
            DefensiveUnitCannon.defensivePower = 20;
            DefensiveUnitCannon.defenseType = 1;
            DefensiveUnitCannon.defenseRange = 1;
            DefensiveUnitCannon.upgradeCost = 20;
            DefensiveUnitCannon.unitValue = 20;

            DefUtilities.UpgradeUnit(ref DefensiveUnitCannon, ref userPlayer);//goblinkiller eller IDefensiveUnit

            Assert.That(DefensiveUnitCannon.defensiveLevel, Is.EqualTo(1));
            Assert.That(DefensiveUnitCannon.nameDefensiveUnit, Is.EqualTo("CannonTower"));
            Assert.That(DefensiveUnitCannon.defensivePower, Is.EqualTo(20));
            Assert.That(DefensiveUnitCannon.defenseType, Is.EqualTo(1));
            Assert.That(DefensiveUnitCannon.defenseRange, Is.EqualTo(1));
            Assert.That(DefensiveUnitCannon.upgradeCost, Is.EqualTo(20));
            Assert.That(DefensiveUnitCannon.unitValue, Is.EqualTo(20));

            Assert.That(userPlayer.bank, Is.EqualTo(10));
        }
    }
}