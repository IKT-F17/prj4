using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonstersMapsTowers.Interfaces;

namespace MonstersMapsTowers.Class
{
    public class OffensiveUnit : IOffensiveUnit
    {
        public OffensiveUnit(string name, int run, int profit, int start, int end, int tiles)//Bliver start og end ikke fastsat af maps?
        {
            name = nameOffensiveUnit;
            run = runSpeed;
            profit = reward;
            start = startTile;
            end = endTile;
            tiles = offensiveTiles;

        }
        public void Path(int startTile, int endTile, int offensiveTiles)
        {
            //    //pseudo Code
            //    //IOffensiveUnit Mop;
            //    //Mop.Pathfinder(Mop.startTile, Mop.endTile, Mop.offensiveTiles );
        }

        public void Immunites()
        {
            //  Will not be made in this project  
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
