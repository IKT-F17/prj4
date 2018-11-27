using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonstersMapsTowers.Interfaces;

namespace MonstersMapsTowers.Class
{
    public class OffensiveUnit : IOffensiveUnit
    {
        public OffensiveUnit(Stack<string> path)//Bliver start og end ikke fastsat af maps?
        {
            string OffensiveUnit = nameOffensiveUnit;
            int run = runSpeed;
            int profit = reward;
            Stack<string> path_ = path;
            int ID = offensiveUnitID;
            int Hit = hitPoints;
            int Attack = attackPower;
        }

        public void TakeDamage(int damage)
        {
            this.hitPoints -= damage;
        }

        public void Immunites()
        {
            //  Will not be made in this project  
        }

        public string nameOffensiveUnit { get; set; }//gobil, ponys,cats, Orgs
        public int runSpeed { get; set; }//offensive unit speed on map
        public int reward { get; set; }//reward for killing an offensive unit
        public int hitPoints { get; set; }//attack power
        public int offensiveUnitID { get; set; }
        public Stack<string> path { get; set; }
        public int attackPower { get; set; }
    }
}
