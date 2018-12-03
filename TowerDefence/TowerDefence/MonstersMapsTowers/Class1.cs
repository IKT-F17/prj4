using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonstersMapsTowers.Class;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("ib");
        player.bank = 100;
        player.updateBank(-20);
        Console.WriteLine(player.bank);
    }
}