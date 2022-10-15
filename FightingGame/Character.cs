using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame
{
    public class Character
    {
        public Character(string Name, int HP = 1, int Defence = 0, int Attack = 0)
        {
            this.Name = Name;
            this.HP = HP;
            this.Defence = Defence;
            this.Attack = Attack;

        }

        public string Name;
        public int HP;
        public int Defence;
        public int Attack;
        public int XP = 0;

        public void takeDamage(int damage)
        {

            damage -= Defence;
            if (damage < 0)
            {
                damage = 0;
            }
            HP -= damage;

            if (HP < 0)
            {
                HP = 0;
            }
        }

        public bool isDead()
        {
            return HP <= 0;
        }


    }
}