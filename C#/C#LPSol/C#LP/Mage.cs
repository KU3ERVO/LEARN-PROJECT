using System;

namespace Excercises
{
    public class Mage : Player
    {
        public string spell { get; set; }

        public Mage(int power, string name, string spell) : base(power, name)
        {
            this.spell = spell;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nSpell: {spell}";
        }
    }
}
