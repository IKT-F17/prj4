using System.Collections.Generic;
using MonstersMapsTowers.Class;
using MonstersMapsTowers.Class.DefensiveUnits;


namespace MonstersMapsTowers.Interfaces
{
    public interface IDefensiveUnitUtilities
    {
        //  IDefensiveUnit SpawnDefensivUnit(DefensiveUnit type, Maps map, Player player);
        void UpgradeUnit(ref ArcherTower unit, ref Player player);
        void UpgradeUnit(ref CannonTower unit, ref Player player);
        void DowngradeUnit(ref ArcherTower unit, ref Player player);
        void DowngradeUnit(ref CannonTower unit, ref Player player);
        //Bør være generisk
    }
}