using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonstersMapsTowers.Class.DefensiveUnits;
using MonstersMapsTowers.Interfaces;

namespace MonstersMapsTowers.Class
{
    public class DefensiveUnitUtilities : IDefensiveUnitUtilities
    {
        private double consecutivePlacementCostFactor = 1.5; // this is the factor which changes the cost of placing a consecutive tower 
        private double upgradeCostFactor = 1.5; // this is the factor which changes the cost of upgrading a tower.  
                                                //private double downgradeReturnValueFactor =  

        /*  public IDefensiveUnit SpawnDefensivUnit(IDefensiveUnit tower, IMaps map, IPlayer player)
          {
              if (tower.unitCost < player.bank)
              {
                  player.updateBank(tower.unitCost);//update bank
                  return tower;
              }
              else
              {
                  return null;
              }
          }

          public void UpgradeUnit(ref IDefensiveUnit unit, ref IPlayer player)
          {
              if (unit.upgradeCost < player.bank)
              {
                  double valuta = unit.upgradeCost;
                  player.updateBank(- valuta);

                  unit.defensiveLevel = unit.defensiveLevel + 1;
                  //  if we need to be upgrade levels , we'd need the name to be something like: 
                  unit.nameDefensiveUnit = unit.nameDefensiveUnit + " Level " + unit.defensiveLevel;
                  unit.defensivePower = unit.defensivePower + 2; // think we should keep this to addition        
                  //tower.defenseType =
                  //    unit.defenseType; // only necessary if we actually change the tower type when upgrading
                  unit.defenseRange = unit.defenseRange + 1;
                  unit.defensiveTiles = unit.defensiveTiles; //  What is this for ? 
                  unit.upgradeCost = unit.upgradeCost * upgradeCostFactor; //new upprice  
                  unit.unitValue += unit.upgradeCost;


                  //  player.updateBank(-unit.upgradeCost); //subtrac the price from user bank

                  //add the tower to the map list of towers
              }
              else
              {
                  return;

              }
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
          }*/

        public void UpgradeUnit(ref ArcherTower unit, ref Player player)
        {
            if (unit.upgradeCost < player.bank)
            {
                double valuta = unit.upgradeCost;
                player.updateBank(-valuta);

                unit.defensiveLevel = unit.defensiveLevel + 1;
                unit.nameDefensiveUnit = unit.nameDefensiveUnit + " Level " + unit.defensiveLevel;
                unit.defensivePower = unit.defensivePower + 2;
                unit.defenseRange = unit.defenseRange + 1;
                unit.unitValue += unit.upgradeCost;
                unit.upgradeCost = unit.upgradeCost * upgradeCostFactor; //new upprice  


            }
            else
            {
                return;

            }
        }
        public void UpgradeUnit(ref CannonTower unit, ref Player player)
        {
            if (unit.upgradeCost < player.bank)
            {
                double valuta = unit.upgradeCost;
                player.updateBank(-valuta);

                unit.defensiveLevel = unit.defensiveLevel + 1;
                unit.nameDefensiveUnit = unit.nameDefensiveUnit + " Level " + unit.defensiveLevel;
                unit.defensivePower = unit.defensivePower + 2;      
                unit.defenseRange = unit.defenseRange + 1;
                unit.unitValue += unit.upgradeCost;
                unit.upgradeCost = unit.upgradeCost * upgradeCostFactor; //new upprice  

            }
            else
            {
                return;

            }
        }

        public void DowngradeUnit(ref ArcherTower unit, ref Player player)
        {
            ///<summary>
            /// when this feature is calles, we check the towers level.
            /// if the level is 0 the tower is not upgraded, and no action should be3 taken.
            /// if the level is 1 the tower should be downgraded to level 0, appropiate subtractions are made from the towers defensive prpoerties, and the name is adjusted to the "plain name"
            /// if the level is >1 the tower should be downgraded to current level -1, appropiate subtractions are made from the towers defensive prpoerties, and the name is adjusted to "plain name + "level XX" - 1"
            /// </summary>


            if (unit.defensiveLevel > 1)
            {
                player.updateBank(unit.unitValue);
                unit.unitValue = unit.unitValue / unit.defensiveLevel;
                unit.defensiveLevel = unit.defensiveLevel - 1;
                unit.nameDefensiveUnit = "ArcherTower Level " + unit.defensiveLevel;
                unit.defensivePower = unit.defensivePower - 2;
                unit.defenseType = unit.defenseType;   
                unit.defenseRange = unit.defenseRange - 1;
                unit.upgradeCost = unit.upgradeCost / upgradeCostFactor;


            }
            else if (unit.defensiveLevel == 1)
            {
                return;

            }

        }
        public void DowngradeUnit(ref CannonTower unit, ref Player player)
        {
            ///<summary>
            /// when this feature is calles, we check the towers level.
            /// if the level is 0 the tower is not upgraded, and no action should be3 taken.
            /// if the level is 1 the tower should be downgraded to level 0, appropiate subtractions are made from the towers defensive prpoerties, and the name is adjusted to the "plain name"
            /// if the level is >1 the tower should be downgraded to current level -1, appropiate subtractions are made from the towers defensive prpoerties, and the name is adjusted to "plain name + "level XX" - 1"
            /// </summary>

            if (unit.defensiveLevel > 1)
            {
                player.updateBank(unit.unitValue);
                unit.unitValue = unit.unitValue / unit.defensiveLevel;
                unit.defensiveLevel = unit.defensiveLevel - 1;
                unit.nameDefensiveUnit = "CannonTower Level " + unit.defensiveLevel;
                unit.defensivePower = unit.defensivePower - 2;
                unit.defenseType = unit.defenseType;   
                unit.defenseRange = unit.defenseRange - 1;
                unit.upgradeCost = unit.upgradeCost / upgradeCostFactor;


            }
            else if (unit.defensiveLevel == 1)
            {
                return;

            }
        }
    }
}
