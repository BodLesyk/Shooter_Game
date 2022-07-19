using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter_Game
{
    class Warrior
    {
        public int Hp { get; set; }

        public void Shoot(int dmg)
            
        {
            
            Console.WriteLine($"Warrior shoot {dmg} to the enemy");
        }

        public void Death(int hp)
        {
            if(hp < Hp)
            {
                Console.WriteLine("Warrior is dead..");
            }
        }
    }
}
