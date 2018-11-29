using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
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
        public ArcherTower ArcherTower;

        public ArcherTowerUC()
        {
            InitializeComponent();
            TowerHitBox = new Rect(0, 0, 128, 128);
            ArcherTower = new ArcherTower();
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