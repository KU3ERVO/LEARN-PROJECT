using System;

namespace Excercises
{
    public class Warrior : Player
    {
        public string weapon { get; set; }

        public Warrior(int power, string name, string weapon) : base(power, name)
        {
            this.weapon = weapon;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nWeapon: {weapon}";
        }
    }
}
