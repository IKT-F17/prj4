using System;
using System.IO;
using MonstersMapsTowers.Class.Pathing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace UnitTestProject
{
    [TestClass]
    public class MapFileReaderTest
    {
        [TestMethod]
        public void ShouldLoadMapFile()
        {
            var filename = @"MapFiles\Map01.txt";
            Assert.IsTrue(File.Exists(filename));
            var reader = new MapFileReader();

            reader.ReadMapFile(filename);
        }
    }
}
