using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
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
    [TestFixture]
    public class MapsUnitTest
    {
        
        Maps _uut;
        private MapFileReader fakeMapFile;
        private Goblin fakeOffensiveUnits;

        
        [SetUp]
        public void Setup()
        {
            _uut = new Maps("Map01");
            fakeMapFile = Substitute.For<MapFileReader>();
        }

 
        [Test]
        public void TestMapValues()
        {
            
            fakeMapFile.ReadMapFile("Map01");
            var mapName = fakeMapFile.mapName;
            var mapImageFilePath = fakeMapFile.mapImageFilepath;
            var initialPlayerBank = fakeMapFile.initialPlayerBank;
            var timeDelaybetweenSpawns = fakeMapFile.timeDelaybetweenSpawns;
            var numberOfWaves = fakeMapFile.numberOfWaves;
            var numberOfOffensiveUnits = fakeMapFile.numberOfOffensiveUnits;
            var offensiveUnitType = fakeMapFile.offensiveUnitType;
            
            
            Assert.That(fakeMapFile.mapName, Is.EqualTo(mapName));
            Assert.That(fakeMapFile.mapImageFilepath, Is.EqualTo(mapImageFilePath));
            Assert.That(fakeMapFile.initialPlayerBank, Is.EqualTo(initialPlayerBank));
            Assert.That(fakeMapFile.timeDelaybetweenSpawns, Is.EqualTo(timeDelaybetweenSpawns));
            Assert.That(fakeMapFile.numberOfWaves, Is.EqualTo(numberOfWaves));
            Assert.That(fakeMapFile.numberOfOffensiveUnits, Is.EqualTo(numberOfOffensiveUnits));
            Assert.That(fakeMapFile.offensiveUnitType, Is.EqualTo(offensiveUnitType));
            

            
        }

        [Test]
        public void TestGettingMapFunctions()
        {
            fakeMapFile.ReadMapFile("Map01");
            var mapName = "FirstMap";
            //var mapImageFilePath = fakeMapFile.mapImageFilepath;
            var initialPlayerBank = 100;
            var timeDelaybetweenSpawns = 2;
            var numberOfWaves = 5;
            var numberOfOffensiveUnits = 10;
            var offensiveUnitType = "Goblin";

            Assert.That(fakeMapFile.mapName, Is.EqualTo("FirstMap"));
            //Assert.That(fakeMapFile.mapImageFilepath, Is.EqualTo(mapImageFilePath));
            Assert.That(fakeMapFile.initialPlayerBank, Is.EqualTo(100));
            Assert.That(fakeMapFile.timeDelaybetweenSpawns, Is.EqualTo(2));
            Assert.That(fakeMapFile.numberOfWaves, Is.EqualTo(5));
            Assert.That(fakeMapFile.numberOfOffensiveUnits, Is.EqualTo(10));
            Assert.That(fakeMapFile.offensiveUnitType, Is.EqualTo("Goblin"));
        }

    }

}
