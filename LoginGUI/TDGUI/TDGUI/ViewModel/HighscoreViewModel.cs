using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TDGUI.Model;
using TDGUI.View;
using TDGUI.ViewModel;

namespace TDGUI.ViewModel
{
    class HighscoreViewModel : BaseViewModel
    {
        public HighscoreViewModel(Account acc, INavigationService n)
        {
            _acc = acc;
            _nav = n;
        }

        //database opslag

        //_acc = databaseopslag(accID


        //private ICommand _setLabel1Command;

        //public ICommand setLabel1Command
        //{
        //   
        //    set
        //    {
        //       _acc.Scores[scoreID].Map[MapName].MapName;
        //    }
        //}

        //private ICommand _setLabel11Command;

        //public ICommand setLabel11Command
        //{
        //    set
        //    {
        //        _acc.Scores[scoreID].Map[MapName].MapScore;
        //    }
        //}


        public int someHighscore = 100;

        public int somemapscore
        {
            get { return someHighscore; }
            set
            {
                if (value != someHighscore)
                {
                    someHighscore = value;
                    OnPropertyChanged();
                }

            }
        }



        public string Othername = "soeren soerensen";

        public string somemapname
        {
            get { return Othername; }
            set
            {
                if (value != Othername)
                {
                    Othername = value;
                    OnPropertyChanged();
                }

            }
        }

        private ICommand _setLabelHS1Command;

        public ICommand setLabelHS1Command
        {
            get { return _setLabelHS1Command ?? (_setLabelHS1Command = new RelayCommand(setLabelHS1)); }
        }

        private void setLabelHS1()
        {


        }

        private ICommand _closeView;

        public ICommand closesView
        {
            get { return _closeView ?? (_closeView = new RelayCommand(closesViewer)); }
        }

        private void closesViewer()
        {
            _nav.Close();
        }

    }
}
