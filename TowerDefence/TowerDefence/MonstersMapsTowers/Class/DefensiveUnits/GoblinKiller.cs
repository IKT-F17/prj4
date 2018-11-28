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
            upgradeCost = -20;
            unitValue = 20;
            defensiveTiles = 1;
            defensiveLevel = 1;
            unitCost = -20;
            unitId = defensUnitId;

        }

        private double consecutivePlacementCostFactor = 1.5; // this is the factor which changes the cost of placing a consecutive tower 
        private double upgradeCostFactor = 1.5; // this is the factor which changes the cost of upgrading a tower.  
                                                //private double downgradeReturnValueFactor =  

        public IDefensiveUnit SpawnDefensivUnit(IDefensiveUnit type, IMaps map, IPlayer player)
        {
            GoblinKiller tower = new GoblinKiller();
            player.updateBank(type.unitCost);//update bank
            return tower; 
        }

        public void upgradUnit(ref IDefensiveUnit unit, IPlayer player)//hvis jeg laver den om til goblinkiller class, har jeg ikke den med fra Interfacet, men skriver jeg den ikke om, og prøver at teste min goblin, passer typerne ikke sammen :/ 
        {
           GoblinKiller tower = new GoblinKiller();


            tower.defensiveLevel = unit.defensiveLevel + 1;

            //  if we need to be upgrade levels , we'd need the name to be something like: 
            //  unit.nameDefensiveUnit + ($" Level {defensiveLevel} ");
            //tower.nameDefensiveUnit = unit.nameDefensiveUnit + (" upgraded,");//rename the unit
            tower.nameDefensiveUnit = unit.nameDefensiveUnit + " Level " + tower.defensiveLevel;
            tower.defensivePower = unit.defensivePower + 2; // think we should keep this to addition        
            tower.defenseType = unit.defenseType;           // only necessary if we actually change the tower type when upgrading
            tower.defenseRange = unit.defenseRange + 1;
            tower.defensiveTiles = unit.defensiveTiles;     //  What is this for ? 
            tower.upgradeCost = unit.upgradeCost * upgradeCostFactor;//new upprice  
            tower.unitValue = unit.unitValue + unit.upgradeCost;
            unit = tower;
            player.updateBank(unit.upgradeCost);//subtrac the price from user bank
           //add overwrit the old tower
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

            GoblinKiller tower = new GoblinKiller();


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
