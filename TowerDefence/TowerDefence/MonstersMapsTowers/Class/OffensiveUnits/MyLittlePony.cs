using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MonstersMapsTowers.Interfaces;;

namespace MonstersMapsTowers.Class.OffensiveUnits
{
    public class MyLittlePony : IOffensiveUnit
    {
        private int offensiveUnitXSize, offensiveUnitYSize = 20; // Graphic size and hitbox size of the unit

        public MyLittlePony(Stack<string> _path, int _xPos, int _Ypos)
        {
            nameOffensiveUnit = "MyLittlePony";
            runSpeed = 2;
            reward = 15;
            hitPoints = 150;
            attackPower = 1;
            Immunites();
            xSize = offensiveUnitXSize;
            ySize = offensiveUnitYSize;
            xPos = _xPos;
            yPos = _Ypos;
            hitBox = new Rect(xPos, yPos, xSize, ySize);
            path = _path;
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
        private int xSize { get; set; }
        private int ySize { get; set; }
        private int xPos { get; set; }
        private int yPos { get; set; }
        private Rect hitBox { get; set; }
        private Stack<string> path { get; set; }
    }
}
