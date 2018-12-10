using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using MonstersMapsTowers.Class.DefensiveUnits;

namespace TowerDefence.UserControls
{
    /// <summary>
    /// Interaction logic for TowerSelectionToolbarUC.xaml
    /// </summary>
    public partial class TowerSelectionToolbar : UserControl
    {
        private Rectangle _towerClicked = new Rectangle();

        public bool _towerSelected;
        public string _towerSelectedName;

        public ArcherTower ArcherTower { get; private set; }
        public CannonTower CannonTower { get; private set; }

        public TowerSelectionToolbar()
        {
            InitializeComponent();
            SelectTowerCanvas.Background = null;

            _towerSelected = false;
            _towerSelectedName = "";

            InitArcherTower();
            InitCannonTower();
        }

        private void InitArcherTower()
        {
            ArcherTower = new ArcherTower();

            ArcherTowerPrice.Content = ArcherTower.unitCost;
        }
        
        private void InitCannonTower()
        {
            CannonTower = new CannonTower();

            CannonTowerPrice.Content = CannonTower.unitCost;
        }

        private void ArcherTowerBuy_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            TowerSelectionChooser(sender);
        }

        private void CannonTowerBuy_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            TowerSelectionChooser(sender);
        }

        private void TowerSelectionChooser(object sender)
        {
            var tower = sender as Rectangle;

            if (_towerClicked.Name == "") _towerClicked.Name = tower.Name;

            if (_towerClicked.Name != tower.Name) return;

            _towerSelected = !_towerSelected;

            if (_towerSelected)
            {
                tower.Stroke = Brushes.LightGreen;
                _towerSelectedName = tower.Name;
            }
            else
            {
                tower.Stroke = null;
                _towerSelected = false;
            }
        }
    }
}
