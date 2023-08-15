using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DungeonRoguelikeGame
{

    internal class Room
    {
        public GameObject[,] room_map;
        public int size_x, size_y;
        Random r = new Random();

        public Room(int size_x = -1, int size_y = -1)
        {
            if (size_x == -1 || size_y == -1)
            {
                size_x = r.Next(8, 15);
                size_y = r.Next(8, 15);
            }

            this.size_x = size_x;
            this.size_y = size_y;

            room_map = new GameObject[size_x, size_y];

            MakeWallsAround();

            for (int i = 1; i < size_x - 1; i++)
                for (int j = 1; j < size_y - 1; j++)
                    room_map[i, j] = new Floor();
        }

        private void MakeWallsAround()
        {
            for (int i = 0; i < size_x; i++)
            {
                room_map[i, 0] = new Wall();
                room_map[i, size_y - 1] = new Wall();
            }

            for (int j = 0; j < size_y; j++)
            {
                room_map[0, j] = new Wall();
                room_map[size_x - 1, j] = new Wall();
            }
        }

        public void DrawRoom(int start_x = 0, int start_y = 0)
        {
            Console.SetCursorPosition(start_x, start_y);

            for (int i = 0; i < size_x; i++)
            {
                for (int j = 0; j < size_y; j++)
                {
                    Console.ForegroundColor = room_map[i, j].color;
                    Console.Write(room_map[i, j].symbol);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
