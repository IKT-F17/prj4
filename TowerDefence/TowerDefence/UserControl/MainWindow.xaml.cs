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
            var tower1 = new Towers();
            Canvas.SetLeft(tower1,150);
            Canvas.SetTop(tower1, 150);
            Map.Children.Add(tower1);
            
            var tower2 = new Towers();
            Canvas.SetLeft(tower2,0);
            Canvas.SetTop(tower2,0);
            Map.Children.Add(tower2);
        }

    }
}

