using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TextRPG
{
    internal class GameManager
    {
        private Player p1 = new Player(2000, 20, 50, "");

        public void Start()
        {

            Console.WriteLine("WELCOME TO TEXTPG\n\n[1] Start Game\n[2] Load Game");

            var input = Console.ReadLine();

            switch (input)
            {

                case "1":
                    Console.WriteLine("THE GAME IS ON");
                    break;

                case "2":
                    Console.WriteLine("YOU LOADED GAME X");
                    break;
            }

        }

    }
}
