using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using MonstersMapsTowers.Class.OffensiveUnits;

namespace TowerDefence.UserControls
{
    /// <summary>
    /// Interaction logic for GoblinUC.xaml
    /// </summary>
    public partial class GoblinUC : UserControl
    {
        // Mob (Goblin) HitBox (collision detection):
        public Rect MobHitBox = new Rect(0, 0, 2, 2);

        // Creating new mob of type Goblin:
        public Goblin newGoblin;

        public GoblinUC(Stack<string> path)
        {
            InitializeComponent();
            newGoblin = new Goblin(path);
            UpdateHp();
        }

        public void UpdateHp()
        {
            HpBar.Value = newGoblin.hitPoints;
        }
    }
}
