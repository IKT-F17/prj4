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
    public class MyLittlePony : IOffensiveUnit
    {

        public MyLittlePony(Stack<string> _path)
        {
            nameOffensiveUnit = "MyLittlePony";
            runSpeed = 2;
            reward = 15;
            hitPoints = 150;
            attackPower = 1;
            Immunites("");
            path = _path;

        }


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
