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
    class PersonalHighscoreViewModel : BaseViewModel
    {
        public PersonalHighscoreViewModel(Account acc, INavigationService n)
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

        public int somescore = 10;

        public int mapscore
        {
            get { return somescore; }
            set
            {
                if (value != somescore)
                {
                    somescore = value;
                    OnPropertyChanged();
                }

            }
        }



        public string somename = "peterpedal";

        public string mapname
        {
            get { return somename; }
            set
            {
                if (value != somename)
                {
                    somename = value;
                    OnPropertyChanged();
                }
                                            
            }
        }

        private ICommand _setLabel1Command;

        public ICommand setLabel11Command
        {
            get { return _setLabel1Command ?? (_setLabel1Command = new RelayCommand(setLabel1)); }
        }

        private void setLabel1()
        {
            

        }

        private ICommand _closeView;

        public ICommand closeView
        {
            get { return _closeView ?? (_closeView = new RelayCommand(closeViewer)); }
        }

        private void closeViewer()
        {
            _nav.Close();
        }



    }
}
