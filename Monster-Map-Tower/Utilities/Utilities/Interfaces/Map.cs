using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Interfaces
{
    public class Map : IMaps, IDefensiveUnit, IOffensiveUnit
    {
      /*  public Map() //constructor
        {
            
        }*/

        #region IOffensiveUnit

        public void Path()
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
        #endregion

        #region IDefensiveUnit
        public void upgradUnit()
        {

        }

        public void degradUnit()
        {

        }

        public void location()
        {

        }

        public string nameDefensiveUnit { get; set; } //
        public int defendPower { get; set; }//How hard can it hit
        public int defendType { get; set; }//What type of deffens
        public int range { get; set; }//How far
        public int upgradPrice { get; set; }//How much
        public int degradPrice { get; set; }
        public int defensiveTiles { get; set; } //where to place?
        #endregion

        #region IMaps

        public void makeOffensiveUnitPath()
        {

        }

        public void wave()
        {

        }

        public void callWave()
        {

        }

        public void placeDefensiveUnit()
        {

        }

        public string nameMap { get; set; }
        public int tilesTypes { get; set; }
        public int baseTile { get; set; }
        public int spawnTile { get; set; }
        #endregion
    }
}
