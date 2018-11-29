using System.Collections.Generic;
using MonstersMapsTowers.Class;


namespace MonstersMapsTowers.Interfaces
{
    public interface IDefensiveUnitUtilities
    {
        IDefensiveUnit SpawnDefensivUnit(IDefensiveUnit type, IMaps map, IPlayer player);
        void upgradUnit(ref IDefensiveUnit unit, IPlayer player);
        void downgradeUnit(ref IDefensiveUnit unit, IPlayer player);
    }
}