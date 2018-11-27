using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace UserControl
{
    public partial class MainWindow : Window
    {

        /// <summary>
        /// The default MainWindow function.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            var tower = new Towers();
        }

    }
}

