using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TowerDefence
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public string username;
        private void Application_Startup(object sender, StartupEventArgs args)
        {
            //username = args.Args[0];
            MainWindow window = new MainWindow();
            window.Show();
        }
    }
}