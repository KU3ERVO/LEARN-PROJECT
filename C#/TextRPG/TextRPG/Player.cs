using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class Player : Character
    {
        public int level { get; private set; }
        public int exp { get; set; }
        public Player(double maxHealth, double attack, double defense, string name) : base(maxHealth, defense, attack, name)
        {
            this.level = 1;
            this.exp = 0;
        }
    }
}
