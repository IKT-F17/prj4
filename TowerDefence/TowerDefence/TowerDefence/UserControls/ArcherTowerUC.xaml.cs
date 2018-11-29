using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MonstersMapsTowers.Class.DefensiveUnits;

namespace TowerDefence.UserControls
{
    /// <summary>
    /// Interaction logic for ArcherTowerUC.xaml
    /// </summary>
    public partial class ArcherTowerUC : UserControl
    {
        //Rect used for collision detection
        public Rect TowerHitBox;

        //linking Tower class object
        public ArcherTower currentTower;

        public ArcherTowerUC()
        {
            InitializeComponent();
            TowerHitBox = new Rect(0, 0, 142, 142);
            currentTower = new ArcherTower();
        }

        //Method that shows tower attributes
        private void Archer_Tower_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            //TODO
        }

        //Shows tower cover area
        private void Archer_Tower_OnMouseEnter(object sender, MouseEventArgs e)
        {
            if (TowerCoverArea.Visibility != Visibility.Visible)
            {
                TowerCoverArea.Visibility = Visibility.Visible;
            }
        }

        //Hides tower cover area
        private void Archer_Tower_OnMouseLeave(object sender, MouseEventArgs e)
        {
            if (TowerCoverArea.Visibility != Visibility.Hidden)
            {
                TowerCoverArea.Visibility = Visibility.Hidden;
            }
        }
    }
}