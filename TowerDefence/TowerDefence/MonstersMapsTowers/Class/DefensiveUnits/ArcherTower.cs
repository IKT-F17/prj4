﻿using System.Collections.Generic;
using MonstersMapsTowers.Interfaces;

namespace MonstersMapsTowers.Class.DefensiveUnits
{
    public class ArcherTower : IDefensiveUnit
    {

        public ArcherTower(int unitId = 0)
        {
            nameDefensiveUnit = "ArcherTower";
            defensivePower = 5;//damage un offensiveUnit
            defenseType = 1;
            defenseRange = 1;
            upgradeCost = 20;
            unitValue = 20;
            defensiveLevel = 1;
            unitCost = 20;
            unitId = defensiveUnitId;

        }

        public string nameDefensiveUnit { get; set; } //
        public int defensivePower { get; set; }//How hard can it hit
        public int defenseType { get; set; }//What type of defense
        public int defenseRange { get; set; }//How far
        public double upgradeCost { get; set; }//How much
        public double unitValue { get; set; }
        public int defensiveTiles { get; set; }//where to place?
        public int defensiveLevel { get; set; }
        public double unitCost { get; set; }
        public int defensiveUnitId { get; set; }
    }
}
