using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonstersMapsTowers.Interfaces;

namespace MonstersMapsTowers.Class
{
    public class Maps : IMaps
    {
        /*  public Map() //constructor
          {

          }*/


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
