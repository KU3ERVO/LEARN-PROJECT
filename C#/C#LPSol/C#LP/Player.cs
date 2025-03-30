using System;

namespace Excercises
{
    class Player
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

        public string ToString() { return $"{name}\n\nPower: {power}\nHp: {health}"; }
    }
}
