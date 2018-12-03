using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDGUI.Model
{
    class Account : IAccount
    {
        public int? TotalHighscore { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Account()
        {
            this.TotalHighscore = null;
            this.Username = "";
            this.Password = "";
        }

        public Account(string username, string password, int THS)
        {
            this.Username = username;
            this.Password = password;
            this.TotalHighscore = THS;
        }

        public void CreateAccount(IAccount acc)
        {
            this.Username = acc.Username;
            this.Password = acc.Password;
        }

        public void DeleteAccount(IAccount acc)
        {
            acc = null;
        }


        public void Login()
        {
            this.Username = "Guest";
            this.Password = "Guest";
            this.TotalHighscore = null;
        }


        public void Login(IAccount acc)
        {
            //do DB check
        }



        public void Logout(IAccount acc)
        {
            //close form
        }


    }
}
