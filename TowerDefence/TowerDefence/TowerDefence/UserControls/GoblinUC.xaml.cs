using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Windows.Shapes;
using MonstersMapsTowers.Class.OffensiveUnits;

namespace TowerDefence.UserControls
{
    /// <summary>
    /// Interaction logic for GoblinUC.xaml
    /// </summary>
    public partial class GoblinUC : UserControl
    {
        // Mob (Goblin) HitBox (collision detection):
        public Rect MobHitBox = new Rect(0, 0, 20, 20);

        // Creating new mob of type Goblin:
        public Goblin Goblin;

        public GoblinUC(Stack<string> path)
        {
            InitializeComponent();
            Goblin = new Goblin(path);
            HpBar.Maximum = Goblin.hitPoints;
            
            UpdateHp();
        }

        public void UpdateHp()
        {
            HpBar.Value = Goblin.hitPoints;
        }
    }
}
