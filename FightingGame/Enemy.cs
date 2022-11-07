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


    /// Ideas
    /// A system where each enemy is randomly assigned an adjective
    ///     eg. A vicious Orc (+5 attack)
    ///         A weak Orc (-3 attack)
    ///

}