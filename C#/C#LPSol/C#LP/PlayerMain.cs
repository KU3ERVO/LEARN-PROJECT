using System;

namespace Excercises
{
    class PlayerMain
    {
        static void Main(string[] args)
        {
            Player p1 = new Player(200, 10, "Jhon");
            Console.WriteLine(p1.toString());
            Console.ReadLine();
        }
    }
}
