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
            _uut.mapName = fakeMapFile.mapName;
            //_uut.mapImageFilePath = fakeMapFile.mapImageFilepath;
            _uut.initialPlayerBank = fakeMapFile.initialPlayerBank;
            _uut.timeDelaybetweenSpawns = fakeMapFile.timeDelaybetweenSpawns;
            _uut.numberOfWaves = fakeMapFile.numberOfWaves;
            _uut.numberOfOffensiveUnits = fakeMapFile.numberOfOffensiveUnits;
            _uut.offensiveUnitType = fakeMapFile.offensiveUnitType;


            Assert.That(_uut.mapName, Is.EqualTo("FirstMap"));
            //Assert.That(_uut.mapImageFilepath, Is.EqualTo(mapImageFilePath));
            Assert.That(_uut.initialPlayerBank, Is.EqualTo(100));
            Assert.That(_uut.timeDelaybetweenSpawns, Is.EqualTo(2));
            Assert.That(_uut.numberOfWaves, Is.EqualTo(5));
            Assert.That(_uut.numberOfOffensiveUnits, Is.EqualTo(10));
            Assert.That(_uut.offensiveUnitType, Is.EqualTo("Goblin"));



        }


    }

}
