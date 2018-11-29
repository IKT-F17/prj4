using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonstersMapsTowers.Interfaces;

namespace MonstersMapsTowers.Class
{
    public class DefensiveUnit : IDefensiveUnit
    {
        public DefensiveUnit(int unitId = 0)
        {
            nameDefensiveUnit = "";
            defensivePower = 0;//damage un offensiveUnit
            defenseType = 0;
            defenseRange = 0;
            upgradeCost = 0;
            unitValue = 0;
            defensiveLevel = 0;
            unitCost = 0;
            unitId = defensUnitId;

        }

      

        //public void location(int tiles)
        //{
        //    //  this will not be implemented. the gamelogic is responsible for placing and keeping track of each and every tower. also when calling up- or down-grade 
        //    //  functions the object is sent, and because of this the tower itself do not care about placement/location
        //    //location of what?

        //}

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
