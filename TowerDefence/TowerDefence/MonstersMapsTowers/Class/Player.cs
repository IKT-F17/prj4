using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Interfaces;

namespace Utilities.Class
{
    class Player : IPlayer
    {
        public Player(string userName)
        {
            int bank_ = 0;
            string databaseUserName = userName;
        }
        public int bank { get; set; }

    }
}
