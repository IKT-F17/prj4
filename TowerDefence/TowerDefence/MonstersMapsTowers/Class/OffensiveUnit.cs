using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MonstersMapsTowers.Interfaces;

namespace MonstersMapsTowers.Class
{
    public class OffensiveUnit : IOffensiveUnit
    {


        public OffensiveUnit(Stack<string> _path)
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

        public void Immunites(string type)
        {
            //  Will not be made in this project  
        }

        private string nameOffensiveUnit { get; set; }//gobil, ponys,cats, Orgs
        private int runSpeed { get; set; }//offensive unit speed on map
        private int reward { get; set; }//reward for killing an offensive unit
        private int hitPoints { get; set; }//attack power
        private int offensiveUnitID { get; set; }
        private int attackPower { get; set; }
        private Stack<string> path { get; set; }
    }
}
