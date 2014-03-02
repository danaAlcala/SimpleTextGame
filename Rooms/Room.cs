using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTextGame.Rooms
{
    class Room
    {
        public int length { get; set; } // measured in floor units
        public int width { get; set; } // measured in floor units
        public int size { get; set; } // size will be easily calculated with this variable;
        public int[,] map { get; set; } // map is a 2D array; all rooms will be rectangular in shape
        public int numberOfDoors { get; set; } // each door will span one FLOOR_UNIT
        public int numberOfStairs { get; set; } // each staircase will span one FLOOR_UNIT
        public int numberOfTreasureChests { get; set; } // each Treasure Chest will span one FLOOR_UNIT_SQUARE
        const int FLOOR_UNIT = 2; // unit of measure - 2 feet per unit
        const int FLOOR_UNIT_SQUARE = 4; // unit of measure - 2 square feet = 4 feet.

        public Room()
        {
            
        }    
    }
}
    
    

