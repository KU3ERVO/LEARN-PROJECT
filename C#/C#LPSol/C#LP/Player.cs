using System;

namespace Excercises
{
    public class Player : ICharacter
    {
        public double health { get; private set; }
        public string name { get; set; }
        private int power { get; set; }

        public Player( int power, string name)
        {
            this.health = 2000;
            this.power = power;
            this.name = name;
        }

        public virtual string ToString() { return $"\n\n{name}\n\nPower: {power}\nHp: {health}"; }

        public int Attack()
        {
            return power;
        }

        public int Move(int amount)
        {
            return amount;
        }
    }
}
