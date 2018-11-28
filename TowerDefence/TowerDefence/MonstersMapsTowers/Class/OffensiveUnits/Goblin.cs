﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MonstersMapsTowers.Interfaces;

namespace MonstersMapsTowers.Class.OffensiveUnits
{
    public class Goblin : IOffensiveUnit
    {
        public Goblin(Stack<string> path)
        {
            nameOffensiveUnit = "Goblin";
            runSpeed = 1;
            reward = 10;
            hitPoints = 100;
            attackPower = 1;
            Immunites();
            //_path = path;

        }

        
        public void Immunites()
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
    }
}

