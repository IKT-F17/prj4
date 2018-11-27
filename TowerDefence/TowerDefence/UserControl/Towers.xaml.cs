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

        //Creates a defensiveunit object
        public DefensiveUnit Tower = new DefensiveUnit();

        public Towers()
        {
            InitializeComponent();
            //CoverArea = new Rect(Canvas.GetLeft(NewRedTowerCoverAreaPlacement1), Canvas.GetTop(NewRedTowerCoverAreaPlacement1), NewRedTowerCoverAreaPlacement1.Width, NewRedTowerCoverAreaPlacement1.Height);
        }


        private void TowerPlacement1_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("JAJA");
        }

        private void TowerPlacement1_OnMouseEnter(object sender, MouseEventArgs e)
        {
            NewRedTowerCoverAreaPlacement1.Visibility = Visibility.Visible;
        }

        private void TowerPlacement1_OnMouseLeave(object sender, MouseEventArgs e)
        {
            NewRedTowerCoverAreaPlacement1.Visibility = Visibility.Hidden;
        }
    }
}
