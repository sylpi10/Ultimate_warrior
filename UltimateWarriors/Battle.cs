using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateWarriors
{
    class Battle
    {
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("---------  Game Over  --------------");
                    break;
                }
                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("---------  Game Over  --------------");
                    break;
                }
            }
        }
        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            int warAAttack = warriorA.Attack();
            int warBBlock = warriorB.Block();

            int damage2WarB = warAAttack - warBBlock; 

            if (damage2WarB > 0)
            {
                warriorB.Health = warriorB.Health - damage2WarB;
            }
            else
                damage2WarB = 0;

            Console.WriteLine("{0} Attacks {1} and deals {2} Damage", 
                                warriorA.Name,
                                warriorB.Name,
                                damage2WarB);

            Console.WriteLine("{0} has {1} health",
                                warriorB.Name,
                                warriorB.Health);

            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has died and {1} is victorious",
                                     warriorB.Name,
                                     warriorA.Name);

                return "Game Over";
            }
            else return "fight again";
        }
    }
}
