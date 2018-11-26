using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MonstersMapsTowers.Interfaces;

namespace MonstersMapsTowers.Class
{
    public class Maps : IMaps
    {
        /*  public Map() //constructor
          {

          }*/

        public List<IOffensiveUnit> offensiveUnitList { get; private set; }
        #region IMaps

        public void makeOffensiveUnitPath()
        {

        }

        public void waveWith10Units()
        {

            int waveCounter = 0;
            int unitAmount = 10;

            //Adds monsters to wave list
            while (waveCounter < unitAmount)
            {
                spawnMob();
                waveCounter++;
                System.Threading.Thread.Sleep(1000); //Sleep for 1 second

            }

        }

        public void spawnMob()
        {
            OffensiveUnit unit = new OffensiveUnit(0, 0, 0);
            offensiveUnitList.Add(unit);
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
