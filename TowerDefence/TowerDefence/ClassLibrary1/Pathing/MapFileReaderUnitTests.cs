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
            var filename = @"MapFiles\Map01.txt";
            Assert.IsTrue(File.Exists(filename));
            var reader = new MapFileReader();

            reader.ReadMapFile(filename);
        }



    }
}
