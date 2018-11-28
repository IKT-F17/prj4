using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using MonstersMapsTowers.Class.OffensiveUnits;
using MonstersMapsTowers.Interfaces;
using MonstersMapsTowers.Class.Pathing;

namespace MonstersMapsTowers.Class
{
    public class Maps : IMaps
    {
        /*  public Map() //constructor
          {

          }*/

        public List<IOffensiveUnit> offensiveUnitList { get; private set; }
        #region IMaps


        

        public void LoadMap(string mapName)
        {
            var _mapFileReader = new MapFileReader();
            _mapFileReader.LoadMapFile(mapName);



        }


        public void makeOffensiveUnitPath()
        {

        }

        public void wave(IOffensiveUnit unit, int amount, int time)
        {

            var testTimer = new System.Timers.Timer(time);
            int waveCounter = 0;
           

            //Adds monsters to wave list
            while (waveCounter < amount)
            {
                spawnMob(unit);
                waveCounter++;
                testTimer.Interval = time;
                Console.WriteLine("Det virker");
                Console.ReadLine();
            }

        }

        public void spawnMob(IOffensiveUnit unit)
        {
            //var _unit = ;
            //unit = new OffensiveUnit(0, 0, 0);
            //offensiveUnitList.Add(unit); 
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
