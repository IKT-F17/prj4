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

        public MyLittlePony(Stack<string> _path, int _xPos, int _Ypos)
        {
            nameOffensiveUnit = "MyLittlePony";
            runSpeed = 2;
            reward = 15;
            hitPoints = 150;
            attackPower = 1;
            Immunites("");
            
        }


        public void Immunites(string type)
        {

        }

        public void TakeDamage(int damage)
        {
            this.hitPoints -= damage;
        }

        public string nameOffensiveUnit { get; set; }//gobil, ponys,cats, Orgs
        public int runSpeed { get; set; }//offensive unit speed on map
        public int reward { get; set; }//reward for killing an offensive unit
        public int hitPoints { get; set; }//attack power
        public int offensiveUnitID { get; set; }
        public int attackPower { get; set; }
        private Stack<string> path { get; set; }
    }
}
