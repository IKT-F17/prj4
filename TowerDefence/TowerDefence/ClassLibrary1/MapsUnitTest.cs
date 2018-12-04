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
using NUnit.Framework.Internal;

namespace TowerDefenceUnitTest
{
    class MapsUnitTest
    {
        Maps _uut;
        private MapFileReader fakeMapFile;
        private Player fakePlayer;
        private Goblin fakeOffensiveUnits;

        
        [SetUp]
        public void Setup()
        {
            _uut = new Maps("");
            fakeMapFile = Substitute.For<MapFileReader>();

            fakePlayer = Substitute.For<Player>();
            
        }

        [Test]
        public void TestMapBeingLoaded()
        {
            fakeMapFile.LoadMapFile("Map01");
            var mapName = fakeMapFile.mapName;
            var mapImageFilePath = fakeMapFile.mapImageFilepath;
            var initialPlayerBank = fakeMapFile.initialPlayerBank;
            var timeDelaybetweenSpawns = fakeMapFile.timeDelaybetweenSpawns;

            Assert.That(fakeMapFile.mapName, Is.EqualTo(mapName));
            Assert.That(fakeMapFile.mapImageFilepath, Is.EqualTo(mapImageFilePath));
            Assert.That(fakeMapFile.initialPlayerBank, Is.EqualTo(initialPlayerBank));
            Assert.That(fakeMapFile.timeDelaybetweenSpawns, Is.EqualTo(timeDelaybetweenSpawns));

        }
        /*
        public Maps(string mapName) //constructor
        {
            

            var mapfile = new MapFileReader();
            mapfile.LoadMapFile(mapName);
            mapName = mapfile.mapName;
            mapImageFilePath = mapfile.mapImageFilepath;

            initialPlayerBank = mapfile.initialPlayerBank;

            numberOfWaves = mapfile.numberOfWaves;
            numberOfOffensiveUnits = mapfile.numberOfOffensiveUnits;
            offensiveUnitType = mapfile.offensiveUnitType;
            timeDelaybetweenSpawns = mapfile.timeDelaybetweenSpawns;

            rawPath = mapfile.rawPath;
        }
        */
    }

}
