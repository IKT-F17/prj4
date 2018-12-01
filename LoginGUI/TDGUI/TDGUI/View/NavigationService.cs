using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using TDGUI.ViewModel;
using TDGUI.View;

namespace TDGUI.View
{

    class NavigationService : INavigationService
    {
        Window currentWindow;
        public void Show(BaseViewModel vm)
        {
            switch (vm.GetType().Name)
            {
                case "RegisterUserViewModel":
                    currentWindow = new RegisterUserView();
                    currentWindow.ShowDialog();
                    break;
                case "MainMenuViewModel":
                    currentWindow = new MainMenu();
                    currentWindow.ShowDialog();
                    break;
                case "PersonalHighscoreViewModel":
                    currentWindow = new PersonalHighscore();
                    currentWindow.ShowDialog();
                    break;

            }
        }

        public void Close()
        {
            currentWindow.Close();
        }
    }
}