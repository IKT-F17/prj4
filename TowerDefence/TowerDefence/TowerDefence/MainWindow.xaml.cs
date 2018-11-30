using System;
using System.Collections.Generic;
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
        private int MAPY = 304;

        private List<ArcherTowerUC> TowersList = new List<ArcherTowerUC>();
        private List<GoblinUC> MobsList = new List<GoblinUC>();

        private bool _isClicked;
        private Rectangle _towerSelected;

        private bool _mobSpawned = false;
        private int counter = 0;
        #endregion


        #region CONSTRUCTOR & GAME INITIALIZERS
        public MainWindow()
        {
            InitializeComponent();
            GameTickSetup();
            UIElementsInitializer();
        }

        private void UIElementsInitializer()
        {
            
        }
        #endregion


        #region PATH GENERATOR
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
        #endregion


        #region GAME TICKS:
        private void GameTickSetup()
        {
            var timer = new DispatcherTimer();

            timer.Interval = TimeSpan.FromMilliseconds(800); // Tweak this for performance.
            timer.Tick += TimerTick;
            timer.Start();
        }


        // GAME TIMER LOOP:
        private void TimerTick(object sender, EventArgs e)
        {
            if (MobsList.Count != 0) MobMove();

            if (TowersList.Count != 0) CheckHit();
        }
        #endregion


        #region ACTIONS:
        // HIT DETECTION:
        private void CheckHit()
        {
            foreach (var currentTower in TowersList)
                foreach (var currentMob in MobsList)
                    if (currentTower.TowerHitBox.IntersectsWith(currentMob.MobHitBox)) Shoot(currentMob, currentTower);   
        }

        // TOWER SHOOTING:
        private void Shoot(GoblinUC currentMob, ArcherTowerUC currentTower)
                          // TODO: Vil det ikke give mere mening om både tower og mob var en template?
        {
            currentMob.Goblin.hitPoints -= currentTower.ArcherTower.defensivePower;
            currentMob.UpdateHp();
        }

        // END OF PATH:
        private void EndPath(GoblinUC mob)
        {
            KillMob(mob);

            // Removes 1 life from the players HP pool:
            int.TryParse(PlayerHP.Content.ToString(), out var hp);
            PlayerHP.Content = (hp - 1).ToString();
        }

        // MOB IS KILLED:
        private void KillMob(GoblinUC mob)
        {
            // Remove mob object from canvas (map) and MobsList.
            Map1.Children.Remove(mob);
            MobsList.Remove(mob);
        }
        #endregion


        #region SELECT & PLACE:
        // ARCHER TOWER:
        private void ArcherTowerBuy_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SelectTower(sender);
        }

        // CANON TOWER:
        private void CannonTowerBuy_MouseDown(object sender, MouseButtonEventArgs e)
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
            ArcherTowerBuy.Stroke = null;
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
            mob.MobHitBox.X = MAPX + 6;
            //Canvas.SetLeft(VisualHitBox, mob.MobHitBox.X);  // DEBUG HIT BOX
            Canvas.SetTop(mob, MAPY - 4);
            mob.MobHitBox.Y = MAPY + 6;
            //Canvas.SetTop(VisualHitBox, mob.MobHitBox.Y);   // DEBUG HIT BOX
            
            // Drawing user control on canvas:
            Map1.Children.Add(mob);

            MobsList.Add(mob);
        }
        #endregion


        #region MOB MOVEMENT CONTROLS:
        private void MobMove()
        {
            counter = 0; // Used for animation movement delay, if it is enabled future up.

            foreach (var mob in MobsList)
            {
                if (mob.Goblin.path.Count == 0)
                {
                    EndPath(mob);
                    return;
                }

                if (mob.Goblin.hitPoints <= 0)
                {
                    KillMob(mob);
                    return;
                }

                switch (mob.Goblin.path.Pop().ToLower())
                {
                    case "left":
                        Canvas.SetLeft(mob, Canvas.GetLeft(mob) - MOVE);
                        mob.MobHitBox.X -= MOVE;
                        //Canvas.SetLeft(VisualHitBox, mob.MobHitBox.X);    // DEBUG HIT BOX
                        SetZ(mob);
                        break;

                    case "right":
                        Canvas.SetLeft(mob, Canvas.GetLeft(mob) + MOVE);
                        mob.MobHitBox.X += MOVE;
                        //Canvas.SetLeft(VisualHitBox, mob.MobHitBox.X);    // DEBUG HIT BOX
                        SetZ(mob);
                        break;

                    case "up":
                        Canvas.SetTop(mob, Canvas.GetTop(mob) - MOVE);
                        mob.MobHitBox.Y -= MOVE;
                        //Canvas.SetTop(VisualHitBox, mob.MobHitBox.Y);    // DEBUG HIT BOX
                        SetZ(mob);
                        break;

                    case "down":
                        Canvas.SetTop(mob, Canvas.GetTop(mob) + MOVE);
                        mob.MobHitBox.Y += MOVE;
                        //Canvas.SetTop(VisualHitBox, mob.MobHitBox.Y);    // DEBUG HIT BOX
                        SetZ(mob);
                        break;
                }
            }
        }

        private void SetZ(UIElement mob)
        {
            Panel.SetZIndex(mob, -2);
        }

        #endregion
    }
}
