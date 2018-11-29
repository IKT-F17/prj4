using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonstersMapsTowers.Interfaces;

namespace MonstersMapsTowers.Class.DefensiveUnits
{
    public class CannonTower : IDefensiveUnit
    {
        public CannonTower(int unitId = 0)
        {
            nameDefensiveUnit = "CannonTower";
            defensivePower = 30;//damage un offensiveUnit
            defenseType = 2;
            defenseRange = 1;
            upgradeCost = 40;
            unitValue = 40;
            defensiveLevel = 1;
            unitCost = 50;
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
