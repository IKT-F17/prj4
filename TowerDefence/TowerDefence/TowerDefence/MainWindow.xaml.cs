using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace TowerDefence
{
    public partial class MainWindow : Window
    {
        private int MOVE = 32;

        private Rect Mob;
        private List<Rect> MobList;
        private Rect Tower;
        private List<Rect> TowerList;

        private Stack<string> Path;

        private bool _isClicked;
        private Rectangle _towerSelected;
        private bool _collision = false;

        private int counter = 0;
        private bool mobSpawned = false;
        private double HP = 100;

        public MainWindow()
        {
            InitializeComponent();

            GeneratePath();
            GameTickSetup();
        }

        private void GeneratePath()
        {
            var stack = new Stack<string>();

            stack.Push("left");
            stack.Push("left");
            stack.Push("left");
            stack.Push("left");
            stack.Push("left");
            stack.Push("left");
            stack.Push("down");
            stack.Push("down");
            stack.Push("down");
            stack.Push("left");
            stack.Push("left");
            stack.Push("left");
            stack.Push("left");
            stack.Push("left");
            stack.Push("up");
            stack.Push("up");
            stack.Push("up");
            stack.Push("up");
            stack.Push("up");
            stack.Push("up");
            stack.Push("left");
            stack.Push("left");
            stack.Push("left");
            stack.Push("left");
            stack.Push("left");
            stack.Push("left");
            stack.Push("left");
            stack.Push("left");
            stack.Push("left");
            stack.Push("down");
            stack.Push("down");
            stack.Push("down");
            stack.Push("right");
            stack.Push("right");
            stack.Push("right");
            stack.Push("right");
            stack.Push("right");
            stack.Push("right");
            stack.Push("down");
            stack.Push("down");
            stack.Push("down");
            stack.Push("left");
            stack.Push("left");
            stack.Push("left");
            stack.Push("left");
            stack.Push("left");
            stack.Push("left");
            stack.Push("left");
            stack.Push("left");
            stack.Push("left");
            stack.Push("left");
            stack.Push("up");
            stack.Push("up");
            stack.Push("up");
            stack.Push("up");
            stack.Push("up");
            stack.Push("left");
            stack.Push("left");
            stack.Push("left");
            stack.Push("left");
            stack.Push("left");

            Path = stack;
        }

        #region GAME TICKS:
        private void GameTickSetup()
        {
            var timer = new DispatcherTimer();

            timer.Interval = TimeSpan.FromMilliseconds(20); // Tweak this for performance.
            timer.Tick += TimerTick;
            timer.Start();
        }

        // GAME TIMER LOOP:
        private void TimerTick(object sender, EventArgs e)
        {
            //lblTime.Content = DateTime.Now.ToString("HH:mm:ss.fff");

            // TODO: Collision detection check pr. tick.
            //foreach (var Mob in Mobs)

            _collision = Tower.IntersectsWith(Mob);
            if (_collision)
            {
                //MessageBox.Show(_collision.ToString());
                //TODO: Call function to damage the mob.
                //Shoot();
            }

            // Mob movement (change the conditions equals number to influence mob speed):
            if (mobSpawned)
            {
                counter++;
                if (counter == 4) MobMove();
            }
        }

        //private void Shoot()
        //{
        //    if ((int) MobHP.Content != 0)   // <---- CAST ERROR (NOT VALID). TODO: NEEDS A FIX!
        //    {
        //        MobHP.Content = ((int) (HP - 0.1)).ToString();
        //    }
        //    else
        //    {
        //        MobHP.Content = "0";
        //        Mob2.Visibility = Visibility.Hidden;
        //    }
        //}

        #endregion

        #region SELECT & PLACE:

        // RED TOWER:
        private void NewTowerType1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SelectTower(sender);
        }

        // BLUE TOWER:
        private void NewTowerType2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SelectTower(sender);
        }

        // TOWER PLACEMENT 1:
        private void TowerPlacement1_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            // Prevents event handler from going any future, when no tower is selected.
            if (_towerSelected == null) return;

            // Hides the tower placement graphics.
            TowerPlacement1.Visibility = Visibility.Collapsed;

            Tower = new Rect(Canvas.GetLeft(NewTowerType1Placement1CoverArea), Canvas.GetTop(NewTowerType1Placement1CoverArea), NewTowerType1Placement1CoverArea.Width, NewTowerType1Placement1CoverArea.Height);
            //Towers.Add(Tower);

            // Resetting variables, so a new tower can be selected and placed.
            _towerSelected = null;
            NewTowerType1.Stroke = null;
            _isClicked = false;

            NewTowerType1Placement1.Visibility = Visibility.Visible;
        }

        private void NewRedTowerPlacement1_OnMouseEnter(object sender, MouseEventArgs e)
        {
            NewTowerType1Placement1CoverArea.Visibility = Visibility.Visible;
        }

        private void NewRedTowerPlacement1_OnMouseLeave(object sender, MouseEventArgs e)
        {
            NewTowerType1Placement1CoverArea.Visibility = Visibility.Hidden;
        }

        // GENERAL TOWER FUNCTIONS:
        private void SelectTower(object sender)
        {
            _towerSelected = sender as Rectangle;

            _isClicked = !_isClicked;
            _towerSelected.Stroke = _isClicked ? Brushes.Black : null;
        }

        #endregion

        #region MOB SPAWNS:

        private void BtnSpawnWave_OnClick(object sender, RoutedEventArgs e)
        {
            Mob = new Rect(1056, 297, 20, 20);
            mobSpawned = true;
        }

        #endregion

        #region MOB MOVEMENT CONTROLS:
        private void MobMove()
        {
            var dir = "";
            counter = 0;                                          // Used for animation movement delay

            if (Path.Count != 0)
                dir = Path.Pop();

            switch (dir.ToLower())
            {
                case "left":
                    Canvas.SetLeft(Mob2, Canvas.GetLeft(Mob2) - MOVE);
                    Mob.X = Mob.X - MOVE;
                    break;

                case "right":
                    Canvas.SetLeft(Mob2, Canvas.GetLeft(Mob2) + MOVE);
                    Mob.X = Mob.X - MOVE;
                    break;

                case "up":
                    Canvas.SetTop(Mob2, Canvas.GetTop(Mob2) - MOVE);
                    Mob.Y = Mob.Y - MOVE;
                    break;

                case "down":
                    Canvas.SetTop(Mob2, Canvas.GetTop(Mob2) + MOVE);
                    Mob.Y = Mob.Y + MOVE;
                    break;

                default:
                    MessageBox.Show("No moves made!");
                    break;
            }

            //Canvas.SetLeft(Mob2, Canvas.GetLeft(Mob2) - MOVE);  // Movement for mob.
            //Mob.X = Mob.X - MOVE;                               // Movement for mob hit box.
        }

        private void Mob1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Left:
                    Canvas.SetLeft(Mob1, Canvas.GetLeft(Mob1) - MOVE);
                    Mob.X = Mob.X - MOVE;
                    break;
                case Key.Right:
                    Canvas.SetLeft(Mob1, Canvas.GetLeft(Mob1) + MOVE);
                    Mob.X = Mob.X + MOVE;
                    break;
                case Key.Up:
                    Canvas.SetTop(Mob1, Canvas.GetTop(Mob1) - MOVE);
                    Mob.Y = Mob.Y - MOVE;
                    break;
                case Key.Down:
                    Canvas.SetTop(Mob1, Canvas.GetTop(Mob1) + MOVE);
                    Mob.Y = Mob.Y + MOVE;
                    break;
            }
        }

        #endregion
    }
}
