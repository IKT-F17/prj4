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

        public Maps(string mapName) //constructor
        {
            //var mapToLoad = "_mapName";
            //LoadMap(mapToLoad);

            var mapfile = new MapFileReader(/*mapName*/);
            mapfile.ReadMapFile(mapName);
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

        public void LoadMap(string _mapName)
        {

        }

        //public void Wave()
        //{
        //    var testTimer = new System.Timers.Timer(timeDelaybetweenSpawns);

        //    for (int i = 0; i < numberOfOffensiveUnits; i++)
        //    {
        //        spawnMob(offensiveUnitType);
        //        testTimer.Interval = timeDelaybetweenSpawns;
        //    }
        //}

        //public void spawnMob(string _offensiveUnitType)
        //{
        //    // needs to go into an foreach if we want to spawn more than one type of monster in a wave. + modifications to the Wave()
        //    switch (_offensiveUnitType)
        //    {
        //        case "Goblin":
        //            var goblin = new Goblin(rawPath);
        //            offensiveUnitList.Add(goblin);
        //            break;

        //        case "MyLittlePony":
        //            var pony = new MyLittlePony(rawPath);
        //            offensiveUnitList.Add(pony);
        //            break;

        //        default:
        //            break;
        //    }
        //}

        //public void CallWave()
        //{
        //    for (int i = 0; i < numberOfWaves; i++)
        //    {
        //        Wave();
        //    }
        //}
        
        public string mapName { get; set; }
        public int numberOfWaves { get; set; }
        public int numberOfOffensiveUnits { get; set; }
        public string offensiveUnitType { get; set; }
        public string mapImageFilePath { get; set; }
        public int initialPlayerBank { get; set; }
        public int timeDelaybetweenSpawns { get; set; }
        public Stack<string> rawPath { get; set; }
    }
}
