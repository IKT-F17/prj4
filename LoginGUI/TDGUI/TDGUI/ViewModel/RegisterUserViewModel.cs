using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TDGUI.Model;
using TDGUI.View;
using System.Windows;

namespace TDGUI.ViewModel
{
    class RegisterUserViewModel : BaseViewModel
    {
        public RegisterUserViewModel(INavigationService n)
        {
            
            _nav = n;
        }

        Account account = new Account();

        public string Username
        {
            get => account.Username;
            set
            {
                if (value != account.Username)
                {
                    account.Username = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Password
        {
            get => account.Password;
            set
            {
                if (value != account.Password)
                {
                    account.Password = value;
                    OnPropertyChanged();
                }
            }
        }


        private ICommand _backToLogin;
        public ICommand backToLogin
        {
            get { return _backToLogin ?? (_backToLogin = new RelayCommand(GoBackToLogin)); }
        }

        private void GoBackToLogin()
        {
            _nav.Close();
        }

        private ICommand _CreateUserCommand;

        public ICommand CreateUserCommand
        {
            get { return _CreateUserCommand ?? (_CreateUserCommand = new RelayCommand(CreateUser)); }
        }

        private void CreateUser()
        {
            //database validation - send account.username til db, for at se om den findes.
            //Hvis den ikke finde
            _nav.Close();
            
            MessageBox.Show($"Brugeren er nu oprettet \n Username: {account.Username} \n Password: {account.Password}");
        }


    }


}
