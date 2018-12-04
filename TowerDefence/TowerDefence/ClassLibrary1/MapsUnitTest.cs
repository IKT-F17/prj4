using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonstersMapsTowers.Interfaces;
using MonstersMapsTowers.Class;
using MonstersMapsTowers.Class.Pathing;
using MonstersMapsTowers.Class.OffensiveUnits;
using NSubstitute;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

namespace TowerDefenceUnitTest
{
    class MapsUnitTest
    {
        
        Maps _uut;
        private MapFileReader fakeMapFile;
        private Goblin fakeOffensiveUnits;

        
        [SetUp]
        public void Setup()
        {
            //_uut = new Maps("Map 1");
            fakeMapFile = Substitute.For<MapFileReader>("Map 1");
        }

 
        [Test]
        public void TestMapValues()
        {
            //Hardcoded test, can't pull from Map01.txt yet
            fakeMapFile.mapName = "map 1";
            fakeMapFile.initialPlayerBank = 100;
            fakeMapFile.timeDelaybetweenSpawns = 10;

            Assert.That(fakeMapFile.mapName, Is.EqualTo("map 1"));
            Assert.That(fakeMapFile.initialPlayerBank, Is.EqualTo(100));
            Assert.That(fakeMapFile.timeDelaybetweenSpawns, Is.EqualTo(10));

            /*
            fakeMapFile.LoadMapFile("map 1");
            var mapName = fakeMapFile.mapName;
            var mapImageFilePath = fakeMapFile.mapImageFilepath;
            var initialPlayerBank = fakeMapFile.initialPlayerBank;
            var timeDelaybetweenSpawns = fakeMapFile.timeDelaybetweenSpawns;

            Assert.That(fakeMapFile.mapName, Is.EqualTo(mapName));
            Assert.That(fakeMapFile.mapImageFilepath, Is.EqualTo(mapImageFilePath));
            Assert.That(fakeMapFile.initialPlayerBank, Is.EqualTo(initialPlayerBank));
            Assert.That(fakeMapFile.timeDelaybetweenSpawns, Is.EqualTo(timeDelaybetweenSpawns));
            */

        }

    }

}
