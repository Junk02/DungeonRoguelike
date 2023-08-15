using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonRoguelikeGame
{
    internal class GameObject
    {
        public ConsoleColor color;
        public char symbol;

        public GameObject(ConsoleColor color, char symbol)
        {
            this.color = color;
            this.symbol = symbol;
        }
    }
}
