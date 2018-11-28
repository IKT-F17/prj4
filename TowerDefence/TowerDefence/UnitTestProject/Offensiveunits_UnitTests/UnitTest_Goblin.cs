//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit.Framework;
//using Assert = NUnit.Framework.Assert;
//using MonstersMapsTowers.Class.OffensiveUnits;
//using MonstersMapsTowers.Interfaces;

/*
namespace UnitTestProject
{
    [TestClass]
    class UnitTest_Goblin
    {
        Goblin _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Goblin(0, 0, 0);
        }

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
            Goblin goblin1 = new Goblin(0,0,0);
            Goblin goblin2 = new Goblin(0,0,0);

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

    }
}
*/