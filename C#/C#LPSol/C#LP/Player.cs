using System;
using System.IO;

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

        public void Save() {

            File.WriteAllText("M:\\anhe\\dam\\PRIMEROS PASOS\\LEARN-PROJECT\\C#\\C#LPSol\\C#LP\\save.txt",(this.name + ","+ this.health + ","+ this.power) );
        
        }

        public void Load()
        {

            string data = File.ReadAllText("M:\\anhe\\dam\\PRIMEROS PASOS\\LEARN-PROJECT\\C#\\C#LPSol\\C#LP\\save.txt");

            string[] datarray = data.Split(',');

            name = datarray[0];
            health = double.Parse(datarray[1]);
            power = int.Parse(datarray[2]);

        }

        public static async Task Rem() {

            Console.WriteLine("START");
            await Task.Delay(3000);
            Console.WriteLine("FINISH");

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
