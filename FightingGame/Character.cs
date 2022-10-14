using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame
{
    class Character
    {
        public Character(string Name, int HP = 0, int Defence = 0, int Attack = 0)
        {
            this.Name = Name;
            this.HP = HP;
            this.Defence = Defence;
            this.Attack = Attack;

        }

        public int HP;

        public string Name;

        public int Defence;

        public int Attack;

        

    }
}
