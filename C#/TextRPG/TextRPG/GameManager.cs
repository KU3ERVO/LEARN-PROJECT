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


            bool exit = false;

            while (exit != true)
            {
                Console.WriteLine("WELCOME TO TEXTPG\n\n[1] Start Game\n[2] Load Game\n[3] Settings\n[4] Exit");
                var input = Console.ReadLine();
                switch (input)
                {

                    case "1":
                        Console.WriteLine("THE GAME IS ON");
                        GameLoop();
                        break;

                    case "2":
                        Console.WriteLine("YOU LOADED GAME X");
                        break;
                    case "3":
                        Console.WriteLine("OPTIONS");
                        break;
                    case "4":
                        Console.WriteLine("BYE");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("thats not a valid input");
                        break;
                }
            }

        }

        public void GameLoop()
        {
            Console.WriteLine("What is your name traveler?");
            string name = Console.ReadLine();
            Player player = new Player(2000,50,50,name);
            bool exit = false;

            while (exit != true)
            {
                Console.WriteLine("                                                                        \n\n\n\n\n\n\n\n\n\n\n" +
                                  $" ________________________¬                                        _________________________¬\n" +
                                  $"| Player {name}          |                                       | ENEMY                   |\n" +
                                  $"|                        |                                       |                         |\n" +
                                  $"| HP:                    |                                       | HP:                     |\n" +
                                  $"| Attack:                |                                       |                         |\n" +
                                  $"|________________________|                                       |_________________________|\n" +
                                  "                                                                                            \n" +
                                  " ________________________¬                                                                  \n" +
                                  "|                        |                                                                  \n" +
                                  "| [1] Attack             |                                                                  \n" +
                                  "| [2] Heal               |                                                                  \n" +
                                  "| [3] Exit               |                                                                  \n" +
                                  "| [4] Save               |                                                                  \n" +
                                  "|________________________|                                      \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("not a valid input");
                        break;
                }
            }

        }
    }
}
