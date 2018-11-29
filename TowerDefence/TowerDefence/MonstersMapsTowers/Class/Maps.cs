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

        public Maps() //constructor
        {
            //var mapToLoad = "_mapName";
            //LoadMap(mapToLoad);

            var mapfile = new MapFileReader();
            mapfile.LoadMapFile(mapName);
            mapName = mapfile.mapName;
            mapImageFilePath = mapfile.mapImageFilepath;

            initialPlayerBank = mapfile.initialPlayerBank;

            numberOfWaves = mapfile.numberOfWaves;
            numberOfOffensiveUnits = mapfile.numberOfOffensiveUnits;
            offensiveUnitType = mapfile.offensiveUnitType;
            timeDelaybetweenSpawns = mapfile.timeDelaybetweenSpawns;

            rawPath = mapfile.rawPath;

        }



        public List<IOffensiveUnit> offensiveUnitList { get; private set; }
        #region IMaps




        public void LoadMap(string _mapName)
        {

        }


        //public void makeOffensiveUnitPath()
        //{

        //}

        public void wave()
        {

            var testTimer = new System.Timers.Timer(timeDelaybetweenSpawns);


            //Adds monsters to wave list

            for (int i = 0; i < numberOfOffensiveUnits; i++)
            {
                spawnMob(offensiveUnitType);
                testTimer.Interval = timeDelaybetweenSpawns;
            }



        }


        

        public void spawnMob(string _offensiveUnitType)
        {
            //var unit = new OffensiveUnit(null);

            // needs to go into an foreach if we want to spawn more than one type of monster in a wave. 
            //switch (_offensiveUnitType)
            //{
                
            //    case "Goblin":
            //        var unit = new Goblin(rawPath);
            //        offensiveUnitList.Add(unit);
            //        break;

            //    case "MyLittlePony":
            //        var unit = new MyLittlePony(rawPath);
            //        offensiveUnitList.Add(unit);
            //        break;


            //    default:
            //        break;
            //}


            


            //var _unit = ;
            //unit = new OffensiveUnit(0, 0, 0);
            //offensiveUnitList.Add(unit); 
        }

        public void callWave()
        {
            for (int i = 0; i < numberOfWaves; i++)
            {
                wave();
            }

        }

        public void placeDefensiveUnit()
        {

        }

        private string mapName { get; set; }
        private int numberOfWaves { get; set; }
        private int numberOfOffensiveUnits { get; set; }
        private string offensiveUnitType { get; set; }
        private string mapImageFilePath { get; set; }
        private int initialPlayerBank { get; set; }
        private int timeDelaybetweenSpawns { get; set; }
        private Stack<string> rawPath { get; set; }


        #endregion
    }
}
