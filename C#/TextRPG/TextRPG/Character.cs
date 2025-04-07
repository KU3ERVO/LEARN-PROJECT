using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class Character
    {
        public double health { get; set; }
        public double maxHealth { get; set; }
        public string name { get; set; }
        public double attack { get; set; }
        public double defense { get; set; }

        public Character(double maxHealth,double attack,double defense,string name)
        {
            this.maxHealth = maxHealth;
            this.attack = attack;
            this.defense = defense;
            this.name = name;
        }

        public double Attack() {
            return this.attack;
        }
        public double Defend() {
            return this.defense; 
        }
        public double Heal() {
            this.health += this.maxHealth attack;
            return health;
        }
    }
}
