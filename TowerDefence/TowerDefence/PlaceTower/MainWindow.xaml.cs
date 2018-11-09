using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PlaceTower
{
    public partial class MainWindow : Window
    {
        private bool _isClicked;
        private Rectangle _towerSelected;
        private bool _collision = false;

        /// <summary>
        /// The default MainWindow function.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            var timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(20); // Tweak this for performance.
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        // GAME TIMER LOOP:
        private void Timer_Tick(object sender, EventArgs e)
        {
            //lblTime.Content = DateTime.Now.ToString("HH:mm:ss.fff");

            //Canvas.SetLeft(Mob1, Canvas.GetLeft(Mob1) - 4);

            // TODO: Collision detection check pr. tick.

        }

        #region SELECT & PLACE:

        // RED TOWER:
        private void NewRedTower_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _towerSelected = sender as Rectangle;
            _isClicked = !_isClicked;
            _towerSelected.Stroke = _isClicked ? Brushes.Black : null;
        }

        // BLUE TOWER:
        // TODO: Implement this.
        /*private void NewBlueTower_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (_isClicked)
            {

                return;
            }
            _towerSelected = sender as Rectangle;
            _isClicked = !_isClicked;
            _towerSelected.Stroke = _isClicked ? Brushes.Black : null;
        }*/

        #region TOWER PLACEMENT 1:

        private void TowerPlacement1_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            // Prevents event handler from going any future, when no tower is selected.
            if (_towerSelected == null) return;
            
            // Hides the tower placement graphics.
            TowerPlacement1.Visibility = Visibility.Collapsed;

            // Resetting variables, so a new tower can be selected and placed.
            _towerSelected = null;
            NewRedTower.Stroke = null;
            _isClicked = false;

            NewRedTowerPlacement1.Visibility = Visibility.Visible;

            // TODO create hitbox.

        }

        private void NewRedTowerPlacement1_OnMouseEnter(object sender, MouseEventArgs e)
        {
            NewRedTowerCoverAreaPlacement1.Visibility = Visibility.Visible;
        }

        private void NewRedTowerPlacement1_OnMouseLeave(object sender, MouseEventArgs e)
        {
            NewRedTowerCoverAreaPlacement1.Visibility = Visibility.Hidden;
        }

        #endregion

        #region TOWER PLACEMENT 2:

        private void TowerPlacement2_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            // Prevents event handler from going any future, when no tower is selected.
            if (_towerSelected == null) return;

            // Hides the tower placement graphics.
            TowerPlacement2.Visibility = Visibility.Collapsed;

            // Resetting variables, so a new tower can be selected and placed.
            _towerSelected = null;
            NewRedTower.Stroke = null;
            _isClicked = false;

            NewRedTowerPlacement2.Visibility = Visibility.Visible;
        }

        private void NewRedTowerPlacement2_OnMouseEnter(object sender, MouseEventArgs e)
        {
            NewRedTowerCoverAreaPlacement2.Visibility = Visibility.Visible;
        }

        private void NewRedTowerPlacement2_OnMouseLeave(object sender, MouseEventArgs e)
        {
            NewRedTowerCoverAreaPlacement2.Visibility = Visibility.Hidden;
        }

        #endregion

        #endregion

        #region MOBS:

        private void Mob1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Left:
                    //Canvas.SetLeft(Mob1, 224);
                    Canvas.SetLeft(Mob1, Canvas.GetLeft(Mob1) - 4);
                    break;
                case Key.Right:
                    //Canvas.SetLeft(Mob1, 264);
                    Canvas.SetLeft(Mob1, Canvas.GetLeft(Mob1) + 4);
                    break;
            }
        }

        #endregion

    }
}
