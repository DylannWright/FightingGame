using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame
{
    public class Encounter
    {
        public Encounter()
        {
            hero = new PlayerCharacter();
            monster = new Enemy();
        }

        private Character hero;
        private Character monster;

        public void start()
        {
            Console.WriteLine($"You encountered a {monster.Name}");
        }

        public void battle()
        {
            bool fighting = true;
            while (fighting)
            {
                int decision = choice();
                if (decision == 1)
                {
                    fight();
                    if (monster.isDead() & hero.isDead())
                    {
                        Console.WriteLine($"You defeated the {monster.Name} but in its last act, it took you down with it");
                        fighting = false;
                    }
                    else if (hero.isDead())
                    {
                        Console.WriteLine("You died heroically");
                        fighting = false;
                    }
                    else if (monster.isDead())
                    {
                        Console.WriteLine($"You slayed the vicious {monster.Name}");
                        fighting = false;
                    }
                    else
                    {
                        Console.WriteLine($"You and the {monster.Name} both still stand");
                    }
                }
                else
                {
                    Console.WriteLine($"You flee the {monster.Name}");
                    fighting = false;
                }
            }
        }



        public int choice()
        {
            int pChosen = 0;
            while (pChosen == 0)
            {
                Console.WriteLine("You can:");
                Console.WriteLine("1 | Fight");
                Console.WriteLine("2 | Flee");
                string pChoice = Console.ReadLine();
                if (pChoice == "1")
                {
                    pChosen = 1;
                }
                else if (pChoice == "2")
                {
                    pChosen = 2;
                }
                else
                {
                    Console.WriteLine("Not a valid choice");
                }
            }
            return pChosen;
        }





        public void fight()
        {
            monster.takeDamage(hero.Attack);
            hero.takeDamage(monster.Attack);
        }
    }
}