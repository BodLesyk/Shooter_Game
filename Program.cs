using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            warrior.Hp = 100;
            Dragon drake = new Dragon();
            drake.Hp = 500;
            Fight.WarriorVsDragon(drake, warrior);
            Fight.Round1(drake, warrior);


            Console.ReadKey();

        }
    }
}
