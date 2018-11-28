using System.Collections.Generic;
using MonstersMapsTowers.Class;

namespace MonstersMapsTowers.Interfaces
{
    public interface IDefensiveUnit//Tower
    {
        IDefensiveUnit SpawnDefensivUnit(IDefensiveUnit type, IMaps map, IPlayer player);
        void upgradUnit(ref IDefensiveUnit unit, IPlayer player);
        void downgradeUnit(IDefensiveUnit unit, IPlayer player);
        
        string nameDefensiveUnit { get; set; } //
        int defensivePower { get; set; }//How hard can it hit
        int defenseType { get; set; }//What type of deffens
        int defenseRange { get; set; }//How far
        double upgradeCost { get; set; }//How much
        double unitValue { get; set; }
        int defensiveTiles { get; set; }//where to place?
        int defensiveLevel { get; set; }
        double unitCost { get; set; }
        int defensUnitId { get; set; }

    }
}