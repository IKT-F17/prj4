using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDGUI.ViewModel;
using TDGUI.Model;


// This class has the responsibility of creating "ViewModels"
namespace TDGUI.View
{
    class Locator
    {
        Account acc = new Account();
        NavigationService nav = new NavigationService();
        public RegisterUserViewModel CreateUserVM => new RegisterUserViewModel(nav);
        public MainWindowViewModel MainWindowVM => new MainWindowViewModel(nav); 
        public MainMenuViewModel MainMenuVM => new MainMenuViewModel(acc, nav);
        public PersonalHighscoreViewModel PersonalHighscoreVM => new PersonalHighscoreViewModel(acc, nav);
        public HighscoreViewModel HighscoreVM => new HighscoreViewModel(acc,nav);

    }
}
