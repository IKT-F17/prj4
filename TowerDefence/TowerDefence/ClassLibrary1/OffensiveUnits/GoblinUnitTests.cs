using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using MonstersMapsTowers.Class.OffensiveUnits;
using MonstersMapsTowers.Class.Pathing;
using MonstersMapsTowers.Interfaces;

namespace TowerDefenceUnitTest.OffensiveUnits
{
    [TestFixture]


    public class GoblinUnitTests
    {
        Goblin _uut;

        [SetUp]
        public void Setup()
        {
            var _path = mapFile.rawPath;
            _uut = new Goblin(_path);
        }
        MapFileReader mapFile = new MapFileReader();

        [Test]
        public void CreatingGoblinUnit()
        {
            Assert.That(_uut.nameOffensiveUnit, Is.EqualTo("Goblin"));
            Assert.That(_uut.runSpeed, Is.EqualTo(1));
            Assert.That(_uut.reward, Is.EqualTo(10));
            Assert.That(_uut.hitPoints, Is.EqualTo(100));
            Assert.That(_uut.attackPower, Is.EqualTo(1));
        }

        [Test]
        public void CreatingMultipleGoblins()
        {
            var _path = mapFile.rawPath;

            Goblin goblin1 = new Goblin(_path);
            Goblin goblin2 = new Goblin(_path);

            Assert.That(goblin1.nameOffensiveUnit, Is.EqualTo(goblin2.nameOffensiveUnit));
            Assert.That(goblin1.runSpeed, Is.EqualTo(goblin2.runSpeed));
            Assert.That(goblin1.reward, Is.EqualTo(goblin2.reward));
            Assert.That(goblin1.hitPoints, Is.EqualTo(goblin2.hitPoints));
            Assert.That(goblin1.attackPower, Is.EqualTo(goblin2.attackPower));
        }

        [Test]
        public void CheckingForFalse()
        {
            Assert.AreNotEqual(_uut.runSpeed, 0);
            Assert.AreNotEqual(_uut.runSpeed, 2);
            Assert.AreNotEqual(_uut.reward, 9);
            Assert.AreNotEqual(_uut.reward, 11);
            Assert.AreNotEqual(_uut.hitPoints, 99);
            Assert.AreNotEqual(_uut.hitPoints, 101);
            Assert.AreNotEqual(_uut.attackPower, 0);
            Assert.AreNotEqual(_uut.attackPower, 2);
        }

        [Test]
        public void UnitTakingDamage()
        {
            _uut.TakeDamage(1);
            Assert.That(_uut.hitPoints, Is.EqualTo(99));
        }

    }
}


