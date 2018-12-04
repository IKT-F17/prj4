﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Net.Mime;
using System.Reflection;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace MonstersMapsTowers.Class.Pathing
{
    /// <summary>
    /// Purpose of this class is to read the MapFile containing the informations that are specific to "this" map.
    /// 
    /// </summary>
    public class MapFileReader
    {
        public MapFileReader(string _mapname)
        {
            mapName = "";
            mapImageFilepath = "";
            initialPlayerBank = 0;
            numberOfWaves = 0;
            numberOfOffensiveUnits = 0;
            timeDelaybetweenSpawns = 0;
            offensiveUnitType = "";
            rawPath = null;
        }

        public void LoadMapFile(string mapName)
        {
            /// TODO: code database Filename/path retriever - Need help from Andreas - but lower priority


            //string currentDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            //string path = Path.Combine(currentDirectory, @"\MonstersMapsTowers\MapFiles\fileName.txt");

            //var path = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\MonstersMapsTowers\MapFiles\fileName.txt";
            //var path = Path.Combine(Directory.GetCurrentDirectory(), "\\MonstersMapsTowers\\MapFiles\\fileName.txt");

            var applicationPath = Directory.GetCurrentDirectory();
            //string path = Application.StartupPath + @"\file.txt"

            ///TODO: FIX THE FUCKING PATH TO A RELATIVE PATH! \T
            //string path = @"D:\GIT\PRJ4\prj4\TowerDefence\TowerDefence\MonstersMapsTowers\MapFiles\Map01.txt";
            string path = @".\Map01.txt";



            //"D:\GIT\PRJ4\prj4\TowerDefence\TowerDefence\MonstersMapsTowers\MapFiles\Map01.txt"

            ReadMapFile(path);    // the string needs to be the real path from the database. this is just the temporary hardcoded path and filename. 



        }

        //  This method will only be fully implemented if time allows. 
        /// <summary>
        /// Meaning of this method is take the mapname/MapID as a parameter and use it to get the filename
        /// and filepath from the database and then parse the file
        /// </summary>
        private void ReadMapFile(string FilePathAndName)
        {
            // reading the file into string array
            string[] mapFileLines = System.IO.File.ReadAllLines(FilePathAndName);

            //  Using mapfile to set Map Settings

            mapName = mapFileLines[0];
            mapImageFilepath = mapFileLines[1]; // contains filepath and file name to Map Image - This should be a selection of coordinates with attributes (walkable, towerplacable, start tile, end(base) Tile
            initialPlayerBank = Int32.Parse(mapFileLines[2]); // Starting gold 

            var rawPathString = mapFileLines[3];    // The raw string containing the offensive unit path. 

            numberOfWaves = Int32.Parse(mapFileLines[4]); // # waves in this map
            numberOfOffensiveUnits = Int32.Parse(mapFileLines[5]); // # offensive units pr. Wave
            timeDelaybetweenSpawns = Int32.Parse(mapFileLines[6]);  // time delay before the next offensive unit is spawned. 
            offensiveUnitType = mapFileLines[7]; // type of offensive unit in the wave. 

            #region Debug writelines.

            Debug.WriteLine($"content of vars");
            Debug.WriteLine($"Map name: {mapName}");
            Debug.WriteLine($"Map image filepath: {mapImageFilepath}");
            Debug.WriteLine($"Initial Player Bank Content: {initialPlayerBank}");
            Debug.WriteLine($"Raw Path string: {rawPathString}");
            Debug.WriteLine($"Number of Waves {numberOfWaves}");
            Debug.WriteLine($"Numbers of Units in each Wave: {numberOfOffensiveUnits}");
            Debug.WriteLine($"Delay 'Tween units: {timeDelaybetweenSpawns}");
            Debug.WriteLine($"Unit Type: {offensiveUnitType}");


            #endregion

            rawPath = new Stack<String>(rawPathString.Split(';')); // Splitting the raw string path into bits, and packing them into the stack.
            foreach (var node in rawPath)
            {
                Debug.WriteLine(node);
            }

            //  Instead of splitting this simple string into smaller strings containing instructions, we'd send the collection of coordinates w/ attributes
            //  
            //var path = new Pathfinder().CalculatePath(rawPath);

            return;
        }

        public string mapName { get; set; }
        public string mapImageFilepath { get; set; }
        public int initialPlayerBank { get; set; }
        public int numberOfWaves { get; set; }
        public int numberOfOffensiveUnits { get; set; }
        public int timeDelaybetweenSpawns { get; set; }
        public string offensiveUnitType { get; set; }
        public Stack<string> rawPath { get; set; }
    }
}
