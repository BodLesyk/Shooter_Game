using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter_Game
{
    class Dragon
    {
        public int Hp { get; set; }

        public void Fire(int dmg)
        {
            
            Console.WriteLine($"Dragon hits {dmg} damage");
        }

        public void Death(int hp)
        {
            if(hp < Hp)
            {
                Console.WriteLine("Dragon is dead");
            }
        }
        
       
    }
}
