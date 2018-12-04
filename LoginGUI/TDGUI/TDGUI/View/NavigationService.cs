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
        

        private static Stack<Window> WindowStack = new Stack<Window>();
        public void Show(BaseViewModel vm)
        {
            switch (vm.GetType().Name)
            {
                case "MainWindowViewModel":
                    currentWindow = new MainWindow();
                    WindowStack.Push(currentWindow);
                    currentWindow.ShowDialog();
                    break;

                case "RegisterUserViewModel":
                    currentWindow = new RegisterUserView();
                    WindowStack.Push(currentWindow);
                    currentWindow.ShowDialog();
                    break;
                case "MainMenuViewModel":
                    currentWindow = new MainMenu();
                    WindowStack.Push(currentWindow);
                    currentWindow.ShowDialog();
                    break;
                case "PersonalHighscoreViewModel":
              //      currentWindow.Hide();
                    currentWindow = new PersonalHighscore();
                    WindowStack.Push(currentWindow);
                    currentWindow.ShowDialog();
                    break;
                case "HighscoreViewModel":
                    currentWindow = new Highscore();
                    WindowStack.Push(currentWindow);
                    currentWindow.ShowDialog();
                    break;


            }

        }

        public void Close()
        {
            currentWindow.Close();
            WindowStack.Pop();
            currentWindow = WindowStack.Peek();
            //currentWindow.Show();
        }
    }
}