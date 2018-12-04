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

namespace TowerDefence.UserControls
{
    /// <summary>
    /// Interaction logic for PlayerUC.xaml
    /// </summary>
    public partial class PlayerUC : UserControl
    {
        public Player currentPlayer;
        public Label PlayerHp
        {
            get => PlayerHP;
            set => PlayerHP = value;
        }

        public Label PlayerGold1
        {
            get => PlayerGold;
            set => PlayerGold = value;
        }
        public PlayerUC(String username, int health, double bank = 0 )
        {
            currentPlayer = new Player(username);
            PlayerGold.Content = currentPlayer.bank;
            PlayerHP.Content = health;
            InitializeComponent();
        }
        
    }
}
