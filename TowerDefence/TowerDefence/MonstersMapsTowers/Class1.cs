using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonstersMapsTowers.Class;
using MonstersMapsTowers.Class.Pathing;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("ib");
        player.bank = 100;
        player.updateBank(-20);
        Console.WriteLine(player.bank);

        //MapFileReader mapFileReader = new MapFileReader("map02");
        //mapFileReader.ReadMapFile("map02");


        //Console.WriteLine($"filepath is: {mapFileReader.mapFilePath}");
        //Console.WriteLine($"mapname is: {mapFileReader.mapName}");
        //Console.WriteLine($"offensive unit is: {mapFileReader.offensiveUnitType}");

        //Console.ReadKey();

    }
}