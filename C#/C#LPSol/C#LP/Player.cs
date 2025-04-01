using System;

namespace Excercises
{
    public class Player : ICharacter
    {
        public double health { get; private set; }
        public string name { get; set; }
        public int power { get; set; }

        public Player(int power, string name)
        {
            this.health = 2000;
            this.power = power;
            this.name = name;
            TakeDamageEvent += Hit;
            GameManager.AddPlayer();
        }

        public override string ToString() { return $"\n\n{name}\n\nPower: {power}\nHp: {health}"; }

        public int Attack()
        {
            return power;
        }

        public int Move(int amount)
        {
            return amount;
        }

        public delegate void TakeDamage(int amount);

        public event TakeDamage TakeDamageEvent;

        public void Hit(int damage) { 
        
        health -= damage;
        
        }

        public void Collision(Player p) {

            TakeDamageEvent?.Invoke(p.power);
        
        }
    }
}
