﻿using System.Collections.Generic;

namespace MonstersMapsTowers.Interfaces
{
    public interface IOffensiveUnit
    {

        void Immunites();
        void TakeDamage(int damage);
        string nameOffensiveUnit { get; set; }//gobil, ponys,cats, Orgs
        int runSpeed { get; set; }//offensive unit speed on map
        int reward { get; set; }//reward for killing an offensive unit
        int hitPoints { get; set; }//attack power
        int offensiveUnitID { get; set; }
       int attackPower { get; set; }
    }
}
