using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TDGUI.View;
using TDGUI.Model;
using TDGUI.ViewModel;

namespace TDGUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        NavigationService nav = new NavigationService();
        void App_Startup(object sender, StartupEventArgs args)
        {

            MainWindowViewModel vm = new MainWindowViewModel(nav);
            nav.Show(vm);            
            MessageBox.Show("Hej med dig");
        }

   
    }
}
