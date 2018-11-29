using System.Dynamic;
using MonstersMapsTowers.Interfaces;

namespace MonstersMapsTowers.Interfaces
{
    public interface IMaps
    {
        void LoadMap(string _mapName);
        //void makeOffensiveUnitPath();
        void wave();
        void callWave();
        void placeDefensiveUnit();

        //string mapName { get; set; }
        

    }
}
