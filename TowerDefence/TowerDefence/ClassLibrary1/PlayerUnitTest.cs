using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonstersMapsTowers.Class;
using NSubstitute;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace TowerDefenceUnitTest
{
    [TestFixture]
    public class PlayerUnitTest
    {
        Player _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Player("007PonyKiller");
        }

        [Test]
        public void TestPlayerConstrukter()
        {
            Assert.That(_uut.bank, Is.EqualTo(0));
        }

        [Test]
        public void TestPlayerBankSet()
        {
            _uut.bank = 100;
            Assert.That(_uut.bank, Is.EqualTo(100));
        }

        [Test]
        public void TestPlayerUpdateBank_negativLotInBank()
        {
            _uut.bank = 400;
            _uut.updateBank(-300);
            Assert.That(_uut.bank, Is.EqualTo(100));
        }

        [Test]
        public void TestPlayerUpdateBank_negativInBank()
        {
            _uut.bank = 300;
            _uut.updateBank(-300);
            Assert.That(_uut.bank, Is.EqualTo(0));
        }

        [Test]
        public void TestPlayerUpdateBank_posInBank()
        {
            _uut.bank = 300;
            _uut.updateBank(300);
            Assert.That(_uut.bank, Is.EqualTo(600));
        }

        [Test]
        public void TestPlayerUpdateBank_pos0inBank()
        {
            _uut.bank = 0;
            _uut.updateBank(300);
            Assert.That(_uut.bank, Is.EqualTo(300));
        }
        [Test]
        public void TestPlayerUpdateBank_neg0inBank()
        {
            _uut.bank = 0;
            _uut.updateBank(-300);

            Assert.That(_uut.bank, Is.EqualTo(0));
        }
        [Test]
        public void TestPlayerHighscore()
        {
            _uut.Highscore = 10;
            
            Assert.That(_uut.Highscore, Is.EqualTo(10));
        }
        [Test]
        public void TestPlayerHighscore_override()
        {
            _uut.Highscore = 10;
            _uut.Highscore = 100;

            Assert.That(_uut.Highscore, Is.EqualTo(100));
        }
    }
}
