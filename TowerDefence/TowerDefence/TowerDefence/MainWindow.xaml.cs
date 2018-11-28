using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using MonstersMapsTowers.Class.OffensiveUnits;

namespace TowerDefence
{
    public partial class MainWindow : Window
    {
        #region VARIABLES:
        private int MOVE = 32;      // Grid size = 32x32.

        private Rect MobHitBox;
        private List<Rect> MobHitBoxList = new List<Rect>();

        private Rect TowerHitBox;
        private List<Rect> TowerHitBoxList = new List<Rect>();

        private Goblin _newGoblin;
        private List<Goblin> MobsList = new List<Goblin>();

        private Stack<string> Path = new Stack<string>();

        private bool _isClicked;
        private Rectangle _towerSelected;
        //private bool _collision = false;

        private bool _mobSpawned = false;
        private int counter = 0;

        // Test/Temp game attributes:
        private double HP = 100;
        #endregion


        public MainWindow()
        {
            InitializeComponent();

            GeneratePath();
            GameTickSetup();

            //MobHitBox = new Rect(1056, 297, 20, 20);
            //MobHitBoxList.Add(MobHitBox);
        }

        private void GeneratePath()
        {
            //var stack = new Stack<string>();

            Path.Push("left");
            Path.Push("left");
            Path.Push("left");
            Path.Push("left");
            Path.Push("left");
            Path.Push("left");
            Path.Push("down");
            Path.Push("down");
            Path.Push("down");
            Path.Push("left");
            Path.Push("left");
            Path.Push("left");
            Path.Push("left");
            Path.Push("left");
            Path.Push("up");
            Path.Push("up");
            Path.Push("up");
            Path.Push("up");
            Path.Push("up");
            Path.Push("up");
            Path.Push("left");
            Path.Push("left");
            Path.Push("left");
            Path.Push("left");
            Path.Push("left");
            Path.Push("left");
            Path.Push("left");
            Path.Push("left");
            Path.Push("left");
            Path.Push("down");
            Path.Push("down");
            Path.Push("down");
            Path.Push("right");
            Path.Push("right");
            Path.Push("right");
            Path.Push("right");
            Path.Push("right");
            Path.Push("right");
            Path.Push("down");
            Path.Push("down");
            Path.Push("down");
            Path.Push("left");
            Path.Push("left");
            Path.Push("left");
            Path.Push("left");
            Path.Push("left");
            Path.Push("left");
            Path.Push("left");
            Path.Push("left");
            Path.Push("left");
            Path.Push("left");
            Path.Push("up");
            Path.Push("up");
            Path.Push("up");
            Path.Push("up");
            Path.Push("up");
            Path.Push("left");
            Path.Push("left");
            Path.Push("left");
            Path.Push("left");
            Path.Push("left");

            //Path = stack;
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
            // TODO: What needs to run pr. Tick?
            // 1. MobMove();        // Skal vel engentlig ske via "spawn wave"!?
            // 2. HitDetection();   

            // 1.
            if (_mobSpawned) MobMove();

            // 2.
            //if (TowerHitBoxList.Count != 0) Task.Run(()=>CheckHit());   // Forsøg på at løse threading problem.
            if (TowerHitBoxList.Count != 0) CheckHit();
        }
        #endregion


        #region ACTIONS:
        // HIT DETECTION:
        private void CheckHit()
        {
            foreach (var towerHb in TowerHitBoxList)
            {
                foreach (var mobHb in MobHitBoxList)
                {
                        if (towerHb.IntersectsWith(mobHb)) Shoot(/*towerHb, mobHb*/);   // Tænker det måske kunne være super smart hvis man istedet for bare at give hitboxen med videre til Shoot(), så giver både selve tower & mob og deres tilhørende hitboxes?
                }
            }
        }


        // TOWER SHOOTING:
        private void Shoot(/*Rect CurrTower, Rect CurrMob*/)
        {
            /// Forsøg på at fixe threading problem. Give af vores vejleder.
            //Dispatcher.BeginInvoke(new Action(() =>
            //{
            //    int.TryParse(MobHP.Content.ToString(), out var hp);
            //    MobHP.Content = (hp - 1).ToString();
            //}));
            
            //MessageBox.Show("Tower Shooting...");

            int.TryParse(MobHP.Content.ToString(), out var hp);
            MobHP.Content = (hp - 1).ToString();
        }
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

            TowerHitBox = new Rect(Canvas.GetLeft(NewTowerType1Placement1CoverArea), Canvas.GetTop(NewTowerType1Placement1CoverArea), NewTowerType1Placement1CoverArea.Width, NewTowerType1Placement1CoverArea.Height);
            TowerHitBoxList.Add(TowerHitBox);

            // Resetting variables, so a new tower can be selected and placed.
            _towerSelected = null;
            NewTowerType1.Stroke = null;
            _isClicked = false;

            NewTowerType1Placement1.Visibility = Visibility.Visible;
        }

        private void NewRedTowerPlacement1_OnMouseEnter(object sender, MouseEventArgs e)
        {
            if (NewTowerType1Placement1CoverArea.Visibility != Visibility.Visible)
            {
                NewTowerType1Placement1CoverArea.Visibility = Visibility.Visible;
            }
        }

        private void NewRedTowerPlacement1_OnMouseLeave(object sender, MouseEventArgs e)
        {
            if (NewTowerType1Placement1CoverArea.Visibility != Visibility.Collapsed)
            {
                NewTowerType1Placement1CoverArea.Visibility = Visibility.Collapsed;
            }
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
            //_newGoblin = new Goblin(Path, 1056, 297);
            //MobsList.Add(_newGoblin);

            MobHitBox = new Rect(1056, 297, 20, 20);
            MobHitBoxList.Add(MobHitBox);

            _mobSpawned = true;
        }
        #endregion


        #region MOB MOVEMENT CONTROLS:
        private void MobMove()
        {
            var dir = "";
            counter = 0;        // Used for animation movement delay, if it is enabled future up.

            if (Path.Count != 0)
                dir = Path.Pop();

            switch (dir.ToLower())
            {
                // Bliver selvfølgelig nød til at lave en liste med mobs generelt, så hver move kan gå igennem denne pr tick.
                // Kan man updatere en liste? Ville være smart hvis man kunne undgå at fjerne fra listen og added igen. Sikkert super simpelt, men kan ikke se det lige nu.

                case "left":
                    Canvas.SetLeft(Goblin1, Canvas.GetLeft(Goblin1) - MOVE);
                    for (var i = 0; i < MobHitBoxList.Count; i++)
                    {
                        var m = MobHitBoxList[i];
                        MobHitBoxList.Remove(MobHitBoxList[i]);
                        m.X = m.X - MOVE;
                        MobHitBoxList.Add(m);
                    }
                    break;

                case "right":
                    Canvas.SetLeft(Goblin1, Canvas.GetLeft(Goblin1) + MOVE);
                    for (var i = 0; i < MobHitBoxList.Count; i++)
                    {
                        var m = MobHitBoxList[i];
                        MobHitBoxList.Remove(MobHitBoxList[i]);
                        m.X = m.X + MOVE;
                        MobHitBoxList.Add(m);
                    }
                    break;

                case "up":
                    Canvas.SetTop(Goblin1, Canvas.GetTop(Goblin1) - MOVE);
                    for (var i = 0; i < MobHitBoxList.Count; i++)
                    {
                        var m = MobHitBoxList[i];
                        MobHitBoxList.Remove(MobHitBoxList[i]);
                        m.Y = m.Y - MOVE;
                        MobHitBoxList.Add(m);
                    }
                    break;

                case "down":
                    Canvas.SetTop(Goblin1, Canvas.GetTop(Goblin1) + MOVE);
                    for (var i = 0; i < MobHitBoxList.Count; i++)
                    {
                        var m = MobHitBoxList[i];
                        MobHitBoxList.Remove(MobHitBoxList[i]);
                        m.Y = m.Y + MOVE;
                        MobHitBoxList.Add(m);
                    }
                    break;

                //default:
                //    // Når man kommer hertil er Path stacken tom og moben har gået banen igennem.
                //    // TODO: Kald en funktion der skal arbejde med hvad der skal ske med moben nu.
                //    MessageBox.Show("Mob move done.");
                //    _mobSpawned = false;
                //    break;
            }
        }

        private void Mob1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Left:
                    Canvas.SetLeft(MobX, Canvas.GetLeft(MobX) - MOVE);
                    MobHitBox.X = MobHitBox.X - MOVE;
                    break;
                case Key.Right:
                    Canvas.SetLeft(MobX, Canvas.GetLeft(MobX) + MOVE);
                    MobHitBox.X = MobHitBox.X + MOVE;
                    break;
                case Key.Up:
                    Canvas.SetTop(MobX, Canvas.GetTop(MobX) - MOVE);
                    MobHitBox.Y = MobHitBox.Y - MOVE;
                    break;
                case Key.Down:
                    Canvas.SetTop(MobX, Canvas.GetTop(MobX) + MOVE);
                    MobHitBox.Y = MobHitBox.Y + MOVE;
                    break;
            }
        }
        #endregion
    }
}
