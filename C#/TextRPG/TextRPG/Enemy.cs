using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class Enemy : Character
    {
        public Enemy(double maxHealth, double attack, double defense, string name) : base(maxHealth, attack, defense, name)
        {
        }
    }
}
