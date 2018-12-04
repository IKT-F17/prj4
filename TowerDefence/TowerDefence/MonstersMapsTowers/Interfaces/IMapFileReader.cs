using System.Collections.Generic;

namespace MonstersMapsTowers.Interfaces
{
    public interface IMapFileReader
    {
        // void ReadMapFile(string FilePathAndName);
        //void LoadMapFile(string mapName);
        void ReadMapFile();


        string mapName { get; set; }
        string mapImageFilepath { get; set; }
        int initialPlayerBank { get; set; }
        int numberOfWaves { get; set; }
        int numberOfOffensiveUnits { get; set; }
        int timeDelaybetweenSpawns { get; set; }
        string offensiveUnitType { get; set; }
        Stack<string> rawPath { get; set; }


    }
}