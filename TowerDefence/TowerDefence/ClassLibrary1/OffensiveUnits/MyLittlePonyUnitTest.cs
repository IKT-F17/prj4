﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using MonstersMapsTowers.Class.OffensiveUnits;
using MonstersMapsTowers.Class;
using MonstersMapsTowers.Class.Pathing;

namespace TowerDefenceUnitTest.OffensiveUnits
{
    [TestFixture]
    public class MyLittlePonyUnitTest
    {
        MyLittlePony _uut;
        MapFileReader mapFile = new MapFileReader("map 1");

        [SetUp]
        public void Setup()
        {
            var _path = mapFile.rawPath;
            _uut = new MyLittlePony(_path);
        }

        [Test]
        public void TestConstructor_true()
        {
            Assert.That(_uut.nameOffensiveUnit, Is.EqualTo("MyLittlePony"));
            Assert.That(_uut.runSpeed, Is.EqualTo(2));
            Assert.That(_uut.hitPoints, Is.EqualTo(150));
            Assert.That(_uut.reward, Is.EqualTo(15));
            Assert.That(_uut.attackPower, Is.EqualTo(1));
        }

        [Test]
        public void TestConstrutionOnMoreMobs()
        {
            var _path = mapFile.rawPath;

            MyLittlePony pony1 = new MyLittlePony(_path);
            MyLittlePony pony2 = new MyLittlePony(_path);

            Assert.That(pony1.runSpeed, Is.EqualTo(pony2.runSpeed));
            Assert.That(pony1.hitPoints, Is.EqualTo(pony2.hitPoints));
            Assert.That(pony1.reward, Is.EqualTo(pony2.reward));
            Assert.That(pony1.attackPower, Is.EqualTo(pony2.attackPower));
        }
        [Test]
        public void TestConstructor_false()
        {
            Assert.AreNotEqual(_uut.reward, 14);
            Assert.AreNotEqual(_uut.reward, 16);
            Assert.AreNotEqual(_uut.runSpeed, 3);
            Assert.AreNotEqual(_uut.runSpeed, 1);
            Assert.AreNotEqual(_uut.hitPoints, 151);
            Assert.AreNotEqual(_uut.hitPoints, 149);
            Assert.AreNotEqual(_uut.attackPower, 0);
            Assert.AreNotEqual(_uut.attackPower, 2);

        }

    }
}
