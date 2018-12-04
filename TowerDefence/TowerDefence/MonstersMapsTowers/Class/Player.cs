using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonstersMapsTowers.Interfaces;

namespace MonstersMapsTowers.Class
{
   public class Player : IPlayer
    {
        public Player(string userName)
        {
            bank = 0;
            string databaseUserName = userName;
        }
        public double bank { get; set; }
        public int Highscore { get; set; }

        public double updateBank(double sum)
        {
            double newsum = 0;
            
            newsum = this.bank + sum;

            if (newsum >= 0)
            {
                bank = newsum;
            }
                       
            return bank;
        }
    }
}
