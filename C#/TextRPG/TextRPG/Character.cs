using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public abstract class Character
    {
        public double health { get; set; }
        public double maxHealth { get; set; }
        public string name { get; set; }
        public double attack { get; set; }
        public double defense { get; set; }


        public Character(double maxHealth, double attack, double defense, string name)
        {
            this.maxHealth = maxHealth;
            this.attack = attack;
            this.defense = defense;
            this.name = name;
        }

        public void Attack(Character target)
        {
            target.health -= (this.attack - target.defense);
        }
        public void Defend()
        {
        }
        public double Heal()
        {
            this.health += attack;
            if (this.health > maxHealth)
            {
                health = maxHealth;
            }
            return health;
        }
    }
}
