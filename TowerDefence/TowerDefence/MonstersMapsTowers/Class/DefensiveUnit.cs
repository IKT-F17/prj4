﻿using System;
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
            defensiveTiles = 0;
            defensiveLevel = 0;
            unitCost = 0;
            unitId = defensUnitId;

        }

        private double consecutivePlacementCostFactor = 1.5; // this is the factor which changes the cost of placing a consecutive tower 
        private double upgradeCostFactor = 1.5; // this is the factor which changes the cost of upgrading a tower.  
                                                //private double downgradeReturnValueFactor =  

        public List<IDefensiveUnit> SpawnDefensivUnit(IDefensiveUnit type, IMaps map, IPlayer player)
        {
            DefensiveUnit tower = new DefensiveUnit();
            //add to maps def list
            player.updateBank(type.unitCost);//update bank
            return null; //List<DefensiveUnit>; ikke null! 
        }

        public void upgradUnit(IDefensiveUnit unit, IPlayer player)
        {
            DefensiveUnit tower = new DefensiveUnit();


            tower.defensiveLevel = unit.defensiveLevel + 1;
            //  if we need to be upgrade levels , we'd need the name to be something like: 
            //  unit.nameDefensiveUnit + ($" Level {defensiveLevel} ");
            //tower.nameDefensiveUnit = unit.nameDefensiveUnit + (" upgraded,");//rename the unit
            tower.nameDefensiveUnit = unit.nameDefensiveUnit + ($"Level {defensiveLevel}");
            tower.defensivePower = unit.defensivePower + 2; // think we should keep this to addition        
            tower.defenseType = unit.defenseType;           // only necessary if we actually change the tower type when upgrading
            tower.defenseRange = unit.defenseRange + 1;
            tower.defensiveTiles = unit.defensiveTiles;     //  What is this for ? 
            tower.upgradeCost = unit.upgradeCost * upgradeCostFactor;//new upprice  
            tower.unitValue = unit.unitValue + unit.upgradeCost;

            player.updateBank(unit.upgradeCost);//subtrac the price from user bank
            unit = tower;//add overwrit the old tower
            //add the tower to the map list of towers

            //needs the 

            //When this feature is called, adding to
            //power must be added by ?? exp,
            //level 1 up, new name?,
            //new type?, new tiles?
            //new downprice and
            //new upprice  

            //subtrac the price from user bank
            //add overwrit the old tower
            //add the tower to the map list of towers
        }

        public void downgradeUnit(IDefensiveUnit unit, IPlayer player)
        {
            ///<summary>
            /// when this feature is calles, we check the towers level.
            /// if the level is 0 the tower is not upgraded, and no action should be3 taken.
            /// if the level is 1 the tower should be downgraded to level 0, appropiate subtractions are made from the towers defensive prpoerties, and the name is adjusted to the "plain name"
            /// if the level is >1 the tower should be downgraded to current level -1, appropiate subtractions are made from the towers defensive prpoerties, and the name is adjusted to "plain name + "level XX" - 1"
            /// </summary>

            DefensiveUnit tower = new DefensiveUnit();


            if (tower.defensiveLevel > 0)
            {
                tower.defensiveLevel = unit.defensiveLevel - 1;
                tower.nameDefensiveUnit = unit.nameDefensiveUnit + ($"Level {defensiveLevel}");
                tower.defensivePower = unit.defensivePower - 2;
                tower.defenseType = unit.defenseType;   // only necessary if we actually change the tower type when upgrading
                tower.defenseRange = unit.defenseRange - 1;
                tower.defensiveTiles = unit.defensiveTiles;
                tower.upgradeCost = unit.upgradeCost / upgradeCostFactor;
                tower.unitValue = unit.unitValue / defensiveLevel;//ikke brug for en downgrad. 
                player.updateBank(unit.unitValue);
                unit = tower;
            }
            if (tower.defensiveLevel == 1)
            {
                tower.defensiveLevel = unit.defensiveLevel - 1;
                tower.nameDefensiveUnit = unit.nameDefensiveUnit;
                tower.defensivePower = unit.defensivePower - 2;
                tower.defenseType = unit.defenseType;   // only necessary if we actually change the tower type when upgrading
                tower.defenseRange = unit.defenseRange - 1;
                tower.defensiveTiles = unit.defensiveTiles;
                tower.upgradeCost = unit.upgradeCost / upgradeCostFactor;//Hvorfor upgrad??
                tower.unitValue = unit.unitValue / defensiveLevel;
                player.updateBank(unit.unitValue);
                unit = tower;//overskriver den her?
            }
            else
            {
                return;
            }
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
