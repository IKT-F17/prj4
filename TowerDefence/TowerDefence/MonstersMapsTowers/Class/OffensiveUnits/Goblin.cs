using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MonstersMapsTowers.Interfaces;

namespace MonstersMapsTowers.Class.OffensiveUnits
{
    public class Goblin : IOffensiveUnit
    {
        public Goblin(int startTile, int endTile, int offensiveTiles)
        {
            nameOffensiveUnit = "Goblin";
            runSpeed = 1;
            reward = 10;
            hitPoints = 100;
            Immunites();
            Path(startTile, endTile, offensiveTiles);

        }

        public void Path(int startTile, int endTile, int offensiveTiles)
        {

        }
        public void Immunites()
        {

        }

        public string nameOffensiveUnit { get; set; }//gobil, ponys,cats, Orgs
        public int runSpeed { get; set; }//offensive unit speed on map
        public int reward { get; set; }//reward for killing an offensive unit
        public int hitPoints { get; set; }//attack power
        public int startTile { get; set; }
        public int offensiveTiles { get; set; }
        public int endTile { get; set; }
    }
}

