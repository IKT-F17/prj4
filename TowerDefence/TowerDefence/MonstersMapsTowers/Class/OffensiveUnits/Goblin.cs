using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MonstersMapsTowers.Interfaces;

namespace MonstersMapsTowers.Class.OffensiveUnits
{
    public class Goblin : IOffensiveUnit
    {

        public Goblin(Stack<string> _path)
        {
            nameOffensiveUnit = "Goblin";
            runSpeed = 1;
            reward = 10;
            hitPoints = 100;
            attackPower = 1;
            //Immunities("");
            path = _path;
        }

        /// <summary>
        /// Immunities is not implemented at this point in time, it is not pivotal to out understanding og the project as a whole.
        /// IF implemented the purpose is to remove or lessen the damage taken by an offensive unit of a specific type. 
        /// </summary>
        
       public void TakeDamage(int damage)
        {
            this.hitPoints -= damage;
        }

        public string nameOffensiveUnit { get; }//gobil, ponys,cats, Orgs
        public int runSpeed { get; set; }//offensive unit speed on map
        public int reward { get; set; }//reward for killing an offensive unit
        public int hitPoints { get; set; }//attack power
        public int attackPower { get; set; }
        public Stack<string> path { get; set; }
        //public void Immunities { get; set; }
    }
}
