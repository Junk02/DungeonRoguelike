using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonRoguelikeGame
{
    internal class Wall : GameObject
    {
        public Wall() : base(ConsoleColor.Red, '#')
        {

        }
    }
}
