using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using MonstersMapsTowers.Class.Pathing;


namespace ClassLibrary1.Pathing
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
