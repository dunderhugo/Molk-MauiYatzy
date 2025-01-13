using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui_Yatzy.Components.Classes
{
    internal class Player
    {
        string Name { get; set; }
        private int Score { get; set; }
        public Player(string name)
        {
            Name = name;
            Score = 0;
        }
        public override string ToString() => $"{Name}";
        public static List<Player>? PlayerList { get; set; } = new List<Player>();
    }
}
