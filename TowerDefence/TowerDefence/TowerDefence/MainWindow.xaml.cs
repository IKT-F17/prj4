using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using TowerDefence.UserControls;

namespace TowerDefence
{
    public partial class MainWindow : Window
    {
        #region VARIABLES:
        private int MOVE = 32;      // Grid size = 32x32.
        private int MAPX = 1056;
        private int MAPY = 300;

        private List<ArcherTowerUC> TowersList = new List<ArcherTowerUC>();
        private List<GoblinUC> MobsList = new List<GoblinUC>();

        private bool _isClicked;
        private Rectangle _towerSelected;

        private bool _mobSpawned = false;
        private int counter = 0;
        #endregion


        public MainWindow()
        {
            InitializeComponent();
            GameTickSetup();
        }

        private static Stack<string> GeneratePath()
        {
            var tempStack = new Stack<string>();

            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("down");
            tempStack.Push("down");
            tempStack.Push("down");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("up");
            tempStack.Push("up");
            tempStack.Push("up");
            tempStack.Push("up");
            tempStack.Push("up");
            tempStack.Push("up");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("down");
            tempStack.Push("down");
            tempStack.Push("down");
            tempStack.Push("right");
            tempStack.Push("right");
            tempStack.Push("right");
            tempStack.Push("right");
            tempStack.Push("right");
            tempStack.Push("right");
            tempStack.Push("down");
            tempStack.Push("down");
            tempStack.Push("down");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("up");
            tempStack.Push("up");
            tempStack.Push("up");
            tempStack.Push("up");
            tempStack.Push("up");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("left");
            tempStack.Push("left");
            
            return tempStack;
        }


        #region GAME TICKS:
        private void GameTickSetup()
        {
            var timer = new DispatcherTimer();

            timer.Interval = TimeSpan.FromMilliseconds(350); // Tweak this for performance.
            timer.Tick += TimerTick;
            timer.Start();
        }


        // GAME TIMER LOOP:
        private void TimerTick(object sender, EventArgs e)
        {
            if (MobsList.Count != 0) MobMove();

            //if (TowerHitBoxList.Count != 0) Task.Run(()=>CheckHit());   // Forsøg på at løse threading problem.
            if (TowersList.Count != 0) CheckHit();
        }
        #endregion


        #region ACTIONS:
        // HIT DETECTION:
        private void CheckHit()
        {
            foreach (var towerHb in TowersList)
                foreach (var mobHb in MobsList)
                    if (towerHb.TowerHitBox.IntersectsWith(mobHb.MobHitBox)) Shoot(mobHb);   
        }


        // TOWER SHOOTING:
        private void Shoot(GoblinUC currentMob)
        {
            /// Forsøg på at fixe threading problem. Givet af vores vejleder.
            //Dispatcher.BeginInvoke(new Action(() =>
            //{
            //    int.TryParse(MobHP.Content.ToString(), out var hp);
            //    MobHP.Content = (hp - 1).ToString();
            //}));
            
            //MessageBox.Show("Tower Shooting...");

            currentMob.newGoblin.hitPoints -= 15;
            currentMob.UpdateHp();
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

        // TOWER PLACEMENT:
        private void TowerPlacement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            // Prevents event handler from going any future, when no tower is selected.
            if (_towerSelected == null) return;

            // Pattern matching:
            if (!(sender is Rectangle s)) return;

            // Hides the tower placement graphics.
            s.Visibility = Visibility.Hidden;

            // Creating new Tower object and helper variables.
            var point = new Point(Canvas.GetLeft(s) - 43, Canvas.GetTop(s) - 43);
            var tower = new ArcherTowerUC();
            Canvas.SetLeft(tower, point.X);
            tower.TowerHitBox.X = point.X;
            Canvas.SetTop(tower, point.Y);
            tower.TowerHitBox.Y = point.Y;
            Map1.Children.Add(tower);

            TowersList.Add(tower);

            // Resetting variables, so a new tower can be selected and placed.
            _towerSelected = null;
            NewTowerType1.Stroke = null;
            _isClicked = false;
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
            var mob = new GoblinUC(GeneratePath());

            Canvas.SetLeft(mob, MAPX);
            mob.MobHitBox.X = MAPX;
            Canvas.SetTop(mob, MAPY);
            mob.MobHitBox.Y = MAPY;
            // Drawing user control on canvas:
            Map1.Children.Add(mob);

            MobsList.Add(mob);
        }
        #endregion


        #region MOB MOVEMENT CONTROLS:
        private void MobMove()
        {
            counter = 0; // Used for animation movement delay, if it is enabled future up.

            for (var i = 0; i < MobsList.Count; i++)
            {
                // Kan man updatere en liste? Ville være smart hvis man kunne undgå at fjerne fra listen og added igen. Sikkert super simpelt, men kan ikke se det lige nu.

                var dir = "";
                var mob = MobsList[i];
                var path = MobsList[i].newGoblin.path;
                MobsList.Remove(MobsList[i]);

                if (path.Count != 0)
                    dir = path.Pop();

                switch (dir.ToLower())
                {
                    case "left":
                        //Dispatcher.BeginInvoke(new Action(() =>
                        //{
                        //    int.TryParse(MobHP.Content.ToString(), out var hp);
                        //    MobHP.Content = (hp - 1).ToString();
                        //}));
                        Canvas.SetLeft(mob, Canvas.GetLeft(mob) - MOVE);
                        mob.MobHitBox.X = mob.MobHitBox.X - MOVE;
                        MobsList.Add(mob);
                        break;

                    case "right":
                        Canvas.SetLeft(mob, Canvas.GetLeft(mob) + MOVE);
                        mob.MobHitBox.X = mob.MobHitBox.X + MOVE;
                        MobsList.Add(mob);
                        break;

                    case "up":
                        Canvas.SetTop(mob, Canvas.GetTop(mob) - MOVE);
                        mob.MobHitBox.Y = mob.MobHitBox.Y - MOVE;
                        MobsList.Add(mob);
                        break;

                    case "down":
                        Canvas.SetTop(mob, Canvas.GetTop(mob) + MOVE);
                        mob.MobHitBox.Y = mob.MobHitBox.Y + MOVE;
                        MobsList.Add(mob);
                        break;

                    default:
                        // Når man kommer hertil er Path stacken tom og moben har gået banen igennem.
                        // TODO: Kald evt. en funktion der skal arbejde med hvad der skal ske med moben nu.

                        // Fjerner mob grafikken fra canvas.
                        Map1.Children.Remove(mob);

                        // Removes 1 life from the players HP pool:
                        int.TryParse(PlayerHP.Content.ToString(), out var hp);
                        PlayerHP.Content = (hp - 1).ToString();

                        break;
                }
            }
        }
        #endregion
    }
}
