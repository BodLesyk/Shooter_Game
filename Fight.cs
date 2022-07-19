using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter_Game
{
    static class Fight
    {
        public static void WarriorVsDragon(Dragon drake, Warrior warr)
        {
            Console.WriteLine("The game is starting!\nPick your character \n1. Warrior \n2. Dragon");
            string _warr = "Warrior";
            string _drag = "Dragon";

            int choise = Int32.Parse(Console.ReadLine());

            if (choise == 1)
            {
                Console.WriteLine($"Nice choise,{_warr}! Lets clean the world from the dragons!");
            }
            else if (choise == 2)
            {
                Console.WriteLine($"HEHEHE!!!{_drag} is here!Lets kill the humanity!");
            }
            else
            {
                Console.WriteLine("Wrong pick!Try again");
            }
            Console.WriteLine("Fight started:");



        }

        public static void Round1(Dragon drake, Warrior warr)
        {
            int warHpLeft = warr.Hp;
            int dragHpLeft = drake.Hp;

            for (int i = 0; i < 10; i++)
            {

                Random rnd = new Random();
                int warriorDMG = rnd.Next(50, 110);
                int dragonDMG = rnd.Next(10, 20);
                 warHpLeft = warHpLeft - dragonDMG;
                 dragHpLeft = dragHpLeft - warriorDMG;
                Console.ReadKey();
                drake.Fire(dragonDMG);
                Console.WriteLine($"Warrior is {warHpLeft} hp left!\n");
                Console.ReadKey();
                warr.Shoot(warriorDMG);
                Console.WriteLine($"Dragon is {dragHpLeft} hp left!\n");
                

                if (warHpLeft < 0)
                {
                    Console.WriteLine("Warrior is dead! Dragon Wins!");
                    Console.WriteLine("-------------GAME OVER-----------------");

                }
                if (dragHpLeft < 0)
                {
                    Console.WriteLine("Dragon is dead! Warrior Wins!");
                    Console.WriteLine("-------------GAME OVER-----------------");
                }

            }
            
            

        }
        

         
    }
}
