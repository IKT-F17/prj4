﻿using System.Collections.Generic;
using MonstersMapsTowers.Interfaces;

namespace MonstersMapsTowers.Class.DefensiveUnits
{
    public class GoblinKiller : IDefensiveUnit
    {

        public GoblinKiller(int unitId = 0)
        {
            nameDefensiveUnit = "GoblinKiller";
            defensivePower = 20;//damage un offensiveUnit
            defenseType = 1;
            defenseRange = 1;
            upgradeCost = 20;
            unitValue = 20;
            defensiveTiles = 1;
            defensiveLevel = 1;
            unitCost = 20;
            unitId = defensUnitId;

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
        public int defensUnitId { get; set; }
    }
}