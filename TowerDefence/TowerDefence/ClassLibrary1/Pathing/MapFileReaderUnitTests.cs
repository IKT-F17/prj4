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
            string tempRawPath =
                "left;left;left;left;left;left;down;down;down;left;left;left;left;left;up;up;up;up;up;up;left;left;left;left;left;left;left;left;left;down;down;down;right;right;right;right;right;right;down;down;down;left;left;left;left;left;left;left;left;left;left;up;up;up;up;up;left;left;left;left";

            string _mapname = "map 1";
            var mapFileReader = new MapFileReader(_mapname);

            var filename = @"MapFiles\Map01.txt";
            //"D:\GIT\PRJ4\prj4\TowerDefence\TowerDefence\MonstersMapsTowers\MapFiles\Map01.txt"

            //Assert.IsTrue(File.Exists(filename));

            mapFileReader.LoadMapFile(_mapname);

            //var test = TestContext.CurrentContext.TestDirectory;


            Assert.AreEqual(mapFileReader.mapName,"FirstMap");
            Assert.AreEqual(mapFileReader.mapImageFilepath, "\\MapFiles\\Map01.png");
            Assert.AreEqual(mapFileReader.initialPlayerBank,100);
            Assert.AreEqual(mapFileReader.numberOfWaves,5);
            Assert.AreEqual(mapFileReader.rawPath,tempRawPath);
            Assert.AreEqual()





        }



    }
}
