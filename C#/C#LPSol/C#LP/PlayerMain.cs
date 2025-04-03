using System;
using System.Security.Cryptography;

namespace Excercises
{
    class PlayerMain
    {
        static void Main(string[] args)
        {
            Player p1 = new Player(200, "Jhon");
            Console.WriteLine(p1.ToString());



            Mage m1 = new Mage(300, "Baldur", "Disgust");
            Warrior w1 = new Warrior(100, "Rien", "Sword");
            Console.WriteLine(m1.ToString());
            Console.WriteLine(w1.ToString());

            List<Player> players = new List<Player>();

            players.Add(m1);
            players.Add(w1);

            w1.name = "RIEN GUARDIANNE DE LE GALAZZIE E DEL HIPERESPAZZO";

            foreach (Player p in players)
            {
                Console.WriteLine($"\n\n{p.name}\n{p.Attack()} y {p.Move(1)}");
            }

            m1.Collision(w1);

            Console.WriteLine(m1.health);

            Console.WriteLine("\nNUMBER OF PLAYERS: " + GameManager.playerCount);

            w1.Save();

            w1.name = "ELDELGAS";
            w1.power = 300000000;

            Console.WriteLine(w1.ToString());

            w1.Load();

            Console.WriteLine(w1.ToString() );

            Console.ReadLine();


        }
    }
}
