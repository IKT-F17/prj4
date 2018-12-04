using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TDGUI.Model;
using TDGUI.View;

namespace TDGUI.ViewModel
{
    class MainWindowViewModel : BaseViewModel
    {
        public MainWindowViewModel(INavigationService n)
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

        private ICommand _RegisterUserCommand;
        public ICommand RegisterUserCommand
        {
            get
            {
                return _RegisterUserCommand ?? (_RegisterUserCommand =
                           new RelayCommand(RegisterNewUser));
            }

        }

        private void RegisterNewUser()
        {
            // should navigate to a new window
            RegisterUserViewModel vm = new RegisterUserViewModel(_nav);
            _nav.Show(vm);
            
        }

        private ICommand _loginAsuserCommand;

        public ICommand loginAsUserCommand
        {
            get
            {
                return _loginAsuserCommand ??
                       (_loginAsuserCommand = new RelayCommand(LoginAsUser));
            }
        }

        private void LoginAsUser()
        {
            //Add DB check to see if user exists

            //Code here
            MainMenuViewModel vm = new MainMenuViewModel(account, _nav);
            _nav.Show(vm);
        }

        private ICommand _logOnAsGuestCommand;

        public ICommand logOnAsGuestCommand
        {
            get { return _logOnAsGuestCommand ?? (_logOnAsGuestCommand = new RelayCommand(LoginAsGuest)); }
        }

        private void LoginAsGuest()
        {
            Account Guest = new Account("Guest", "Guest", 0);
            MainMenuViewModel vm = new MainMenuViewModel(Guest, _nav);
            _nav.Show(vm);
        }


    }
}
