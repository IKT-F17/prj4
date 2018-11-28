using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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




        public void LoadMapFile(string mapName)
        {
            //    /// TODO: code database Filename/path retriever - Need help from Andreas - but lower priority
            
            ReadMapFile(@"\MapFiles\Map01.txt");    // the string needs to be the real path from the database. this is just the temporary hardcoded path and filename. 


        }


        //  This method will only be fully implemented if time allows. 
        /// <summary>
        /// Meaning of this method is take the mapname/MapID as a parameter and use it to get the filename
        /// and filepath from the database and then parse the file
        /// </summary>
        public void ReadMapFile(string FilePathAndName)
        {
            // reading the file into string array
            string[] mapFileLines = System.IO.File.ReadAllLines(FilePathAndName);

            //  Using mapfile to set Map Settings

            var mapName = mapFileLines[0];
            var mapImageFilepath = mapFileLines[1]; // contains filepath and file name to Map Image - This should be a selection of coordinates with attributes (walkable, towerplacable, start tile, end(base) Tile
            var initialPlayerBank = Int32.Parse(mapFileLines[2]); // Starting gold 

            var rawPathString = mapFileLines[3];    // The raw string containing the offensive unit path. 

            var numberOfWaves = Int32.Parse(mapFileLines[4]); // # waves in this map
            var numberOfOffensiveUnits = Int32.Parse(mapFileLines[5]); // # offensive units pr. Wave
            var timeDelaybetweenSpawns = Int32.Parse(mapFileLines[6]);  // time delay before the next offensive unit is spawned. 
            var offensiveUnitType = mapFileLines[7]; // type of offensive unit in the wave. 

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

            var rawPath = new Stack<String>(rawPathString.Split(';')); // Splitting the raw string path into bits, and packing them into the stack.
            foreach (var node in rawPath)
            {
                Debug.WriteLine(node);
                
            }

                //  Instead of splitting this simple string into smaller strings containing instructions, we'd send the collection of coordinates w/ attributes
                //  
            var path = new Pathfinder().CalculatePath(rawPath);


            return;




        }



    }
}
