using System.Collections.Generic;

namespace MonstersMapsTowers.Interfaces
{
    public interface IOffensiveUnit
    {
        void TakeDamage(int damage);
        string nameOffensiveUnit { get; }//gobil, ponys,cats, Orgs
        int runSpeed { get; set; }//offensive unit speed on map
        int reward { get; set; }//reward for killing an offensive unit
        int hitPoints { get; set; }//attack power
        int attackPower { get; set; }
        Stack<string> path { get; set; }
        //void Immunities { get; set; }
    }
}
