using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TDGUI.Model;
using TDGUI.View;

namespace TDGUI.ViewModel
{
    class MainMenuViewModel : BaseViewModel
    {
        public MainMenuViewModel(Account acc, INavigationService n)
        {
            _nav = n;
            _acc = acc;
        }


        private ICommand _CreateHighscoreView;

        public ICommand CreateHighscoreView
        {
            get
            {
                return _CreateHighscoreView ?? (_CreateHighscoreView = new RelayCommand(CreateHighscoreViewer));
            }
        }


        private void CreateHighscoreViewer()
        {
            PersonalHighscoreViewModel vm = new PersonalHighscoreViewModel(_acc, _nav);
            _nav.Show(vm);
        }



        private ICommand _CreateGuestHighscoreView;

        public ICommand CreateGuestHighscoreView
        {
            get
            {
                return _CreateGuestHighscoreView ?? (_CreateHighscoreView = new RelayCommand(CreateguestHighscoreViewer));
            }
        }

        private void CreateguestHighscoreViewer()
        {
            HighscoreViewModel vm = new HighscoreViewModel(_acc,_nav);
            _nav.Show(vm);
        }


       
    }
}
