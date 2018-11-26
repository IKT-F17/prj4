using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonstersMapsTowers.Interfaces;

namespace MonstersMapsTowers.Class
{
    class Player : IPlayer
    {
        public Player(string userName)
        {
            double bank_ = 0;
            string databaseUserName = userName;
        }
        public double bank { get; set; }

        public double updateBank(double sum)
        {
            double newsum = 0;
                       
            newsum = bank + sum;
            bank = newsum;
                       
            return bank;
        }
    }
}
