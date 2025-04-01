using System;

namespace Excercises
{
   public static class GameManager
    {
        public static int playerCount { get; private set; }

        public static void AddPlayer()
        {
            playerCount++;
        }
        public static void RemovePlayer()
        {
            playerCount--; 
        }
    }
}
