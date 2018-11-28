using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonstersMapsTowers.Interfaces;

namespace MonstersMapsTowers.Class.DefensiveUnits
{
    public class PonyKiller : IDefensiveUnit
    {
        public PonyKiller(int unitId = 0)
        {
            nameDefensiveUnit = "PonyKiller";
            defensivePower = 30;//damage un offensiveUnit
            defenseType = 2;
            defenseRange = 1;
            upgradeCost = 40;
            unitValue = 40;
            defensiveTiles = 1;
            defensiveLevel = 1;
            unitCost = 50;
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
