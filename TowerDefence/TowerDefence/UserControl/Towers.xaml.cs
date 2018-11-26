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

namespace UserControl
{
    /// <summary>
    /// Interaction logic for Towers.xaml
    /// </summary>
    public partial class Towers : System.Windows.Controls.UserControl
    {

        private Rect CoverArea;
        private bool _isClicked;
        private Rectangle _towerSelected;
        private bool _collision = false;

        public Towers()
        {
            InitializeComponent();
        }
        

        private void TowerPlacement1_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            CoverArea = new Rect(Canvas.GetLeft(NewRedTowerCoverAreaPlacement1), Canvas.GetTop(NewRedTowerCoverAreaPlacement1), NewRedTowerCoverAreaPlacement1.Width, NewRedTowerCoverAreaPlacement1.Height);
        
            MessageBox.Show("JAJA");
        }

        private void TowerPlacement1_OnMouseEnter(object sender, MouseEventArgs e)
        {
            

        }
    }
}
