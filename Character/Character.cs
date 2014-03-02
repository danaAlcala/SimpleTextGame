using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTextGame.Character
{
    class Character // this is a base class for all characters in the game
    {
        public string gender { get; set; }
        public int level { get; set; }
        public string name { get; set; }
        public int hitPoints { get; set; }
        public int attackPower { get; set; }
        public int defense { get; set; }
    }
}
