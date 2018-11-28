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
            Immunites("");
            path = _path;
        }

        /// <summary>
        /// Immunities is not implemented at this point in time, it is not pivotal to out understanding og the project as a whole.
        /// IF implemented the purpose is to remove or lessen the damage taken by an offensive unit of a specific type. 
        /// </summary>
        public void Immunites(string type)
        {
        }

        public void TakeDamage(int damage)
        {
            this.hitPoints -= damage;
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

