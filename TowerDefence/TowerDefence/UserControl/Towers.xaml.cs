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
using MonstersMapsTowers.Class;

namespace UserControl
{
    /// <summary>
    /// Interaction logic for Towers.xaml
    /// </summary>
    public partial class Towers : System.Windows.Controls.UserControl
    {
        //Rect for collision detection
        public Rect CoverArea = new Rect(0,0,142,142);

        //Creates a DefensiveUnit object 
        public DefensiveUnit Tower = new DefensiveUnit();

        public Towers()
        {
            InitializeComponent();
        }
        
        private void TowerPlacement1_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            //TODO
            //Event that shows tower attributes on game screen
            MessageBox.Show("JAJA");
        }

        //Shows the cover area
        private void TowerPlacement1_OnMouseEnter(object sender, MouseEventArgs e)
        {
            NewRedTowerCoverAreaPlacement1.Visibility = Visibility.Visible;
        }

        //Hides the cover area
        private void TowerPlacement1_OnMouseLeave(object sender, MouseEventArgs e)
        {
            NewRedTowerCoverAreaPlacement1.Visibility = Visibility.Hidden;
        }
    }
}
