using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Encounter encounter = new Encounter();
            encounter.start();
            encounter.battle();
        }
    }
}
