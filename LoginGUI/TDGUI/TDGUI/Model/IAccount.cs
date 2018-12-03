using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDGUI.Model
{
    public interface IAccount
    {
        int? TotalHighscore { get; set; }
        string Username { get; set; }
        string Password { get; set; }

        void CreateAccount(IAccount acc);

        void DeleteAccount(IAccount acc);

        void Login(IAccount acc);

        void Logout(IAccount acc);


    }
}
