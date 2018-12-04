using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using MonstersMapsTowers.Class.Pathing;
using NUnit.Framework;

namespace TowerDefenceUnitTest.Pathing
{

    [TestFixture]
    public class MapFileReaderUnitTests
    {
        MapFileReader _uut;

        [SetUp]
        public void Setup()
        {
            string _mapName = "";
            _uut = new MapFileReader();
            
        }
         



        [Test]
        public void ShouldLoadMapFile()
        {
            string _mapname = "map01";
            //var mapFileReader = new MapFileReader(_mapname);
            //var filename = @"MapFiles\Map01.txt";

            string realMapName = "FirstMap";
            string realImageFilePath = "\\MapFiles\\Map01.png";
            int realInitialPlayerBank = 100;
            string realRawPathstring =
                "left;left;left;left;left;left;down;down;down;left;left;left;left;left;up;up;up;up;up;up;left;left;left;left;left;left;left;left;left;down;down;down;right;right;right;right;right;right;down;down;down;left;left;left;left;left;left;left;left;left;left;up;up;up;up;up;left;left;left;left";
            var realPathStack = new Stack<String>(realRawPathstring.Split(';'));
            int realnumberOfWaves = 5;
            int realNumberOfOffensiveUnits = 10;
            int realTimeDelaybetweenSpawns = 2;
            string realOffensiveUnitType = "Goblin";

            

            _uut.ReadMapFile("Map01");
            //_uut.mapFilePath = @"C:\Program Files (x86)\Jenkins\workspace\Projekt_Gruppe7_Coverage\TowerDefence\TowerDefence\ClassLibrary1\MapFiles\"
            Debug.WriteLine(_uut.mapFilePath);
            var filename = _uut.mapFileName;
            
            Assert.IsTrue(File.Exists(_uut.mapFilePath + filename));

            //var test = TestContext.CurrentContext.TestDirectory;

            


            Assert.AreEqual(realMapName, _uut.mapName);
            Assert.AreEqual(realImageFilePath, _uut.mapImageFilepath);
            Assert.AreEqual(realPathStack, _uut.rawPath);
            Assert.AreEqual(realInitialPlayerBank, _uut.initialPlayerBank);
            Assert.AreEqual(realnumberOfWaves, _uut.numberOfWaves);
            Assert.AreEqual(realNumberOfOffensiveUnits, _uut.numberOfOffensiveUnits);
            Assert.AreEqual(realTimeDelaybetweenSpawns, _uut.timeDelaybetweenSpawns);
            Assert.AreEqual(realOffensiveUnitType, _uut.offensiveUnitType);


            //Assert.AreEqual()





        }



    }
}
