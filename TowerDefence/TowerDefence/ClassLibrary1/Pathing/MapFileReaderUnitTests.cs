using System;
using System.Collections.Generic;
using System.IO;
using MonstersMapsTowers.Class.Pathing;
using NUnit.Framework;

namespace TowerDefenceUnitTest.Pathing
{

    [TestFixture]


    public class MapFileReaderUnitTests
    {
        [Test]
        public void ShouldLoadMapFile()
        {
            string realRawPathstring =
                "left;left;left;left;left;left;down;down;down;left;left;left;left;left;up;up;up;up;up;up;left;left;left;left;left;left;left;left;left;down;down;down;right;right;right;right;right;right;down;down;down;left;left;left;left;left;left;left;left;left;left;up;up;up;up;up;left;left;left;left";
            var realPathStack = new Stack<String>(realRawPathstring.Split(';'));
            string _mapname = "map 1";
            var mapFileReader = new MapFileReader(_mapname);
            string realMapName = "FirstMap";
            string realImageFilePath = "\\MapFiles\\Map01.png";
            var filename = @"MapFiles\Map01.txt";
            int realInitialPlayerBank = 100;
            int realnumberOfWaves = 5;

            //"D:\GIT\PRJ4\prj4\TowerDefence\TowerDefence\MonstersMapsTowers\MapFiles\Map01.txt"

            //Assert.IsTrue(File.Exists(filename));

            mapFileReader.LoadMapFile(_mapname);

            //var test = TestContext.CurrentContext.TestDirectory;




            Assert.AreEqual(realMapName, mapFileReader.mapName);
            Assert.AreEqual(realImageFilePath, mapFileReader.mapImageFilepath);
            Assert.AreEqual(realInitialPlayerBank, mapFileReader.initialPlayerBank);
            Assert.AreEqual(realnumberOfWaves, mapFileReader.numberOfWaves);
            Assert.AreEqual(realPathStack, mapFileReader.rawPath);

            //Assert.AreEqual()





        }



    }
}
