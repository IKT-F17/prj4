using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MonstersMapsTowers.Class.DefensiveUnits;

namespace TowerDefence.UserControls
{
    /// <summary>
    /// Interaction logic for CannonTowerUC.xaml
    /// </summary>
    public partial class CannonTowerUC : UserControl
    {
        //Rect used for collision detection
        public Rect TowerHitBox;

        //Linking tower class object
        private CannonTower _currentTower;

        public CannonTowerUC()
        {
            InitializeComponent();
            _currentTower = new CannonTower();
            TowerHitBox = new Rect(0,0,128,128);
        }

        //Method that shows tower attributes
        private void Cannon_Tower_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            //TODO
        }

        //Shows tower cover area
        private void Cannon_Tower_OnMouseEnter(object sender, MouseEventArgs e)
        {
            if (TowerCoverArea.Visibility != Visibility.Visible)
            {
                TowerCoverArea.Visibility = Visibility.Visible;
            }
        }

        //Hides tower cover area
        private void Cannon_Tower_OnMouseLeave(object sender, MouseEventArgs e)
        {
            if (TowerCoverArea.Visibility != Visibility.Hidden)
            {
                TowerCoverArea.Visibility = Visibility.Hidden;
            }
        }
    }
}
