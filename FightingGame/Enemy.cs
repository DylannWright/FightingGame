using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame
{
    public class Enemy : Character
    {
        public Enemy() : base("Orc", 6, 1, 4)
        {
            XP = 50;
        }

    }
}