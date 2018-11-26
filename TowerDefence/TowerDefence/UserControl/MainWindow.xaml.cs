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
        private List<Rect> Towers;
        private List<Rect> Mobs;
        private Rect Mob;
        private Rect Tower;
        private bool _isClicked;
        private Rectangle _towerSelected;
        private bool _collision = false;

        /// <summary>
        /// The default MainWindow function.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

    }
}

