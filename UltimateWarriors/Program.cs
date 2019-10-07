using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateWarriors
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior jetLi = new Warrior("Jet Li", 800, 140, 60);
            Warrior bruceLee = new Warrior("Bruce Lee", 800, 140, 60);

            Battle.StartFight(jetLi, bruceLee);
        }
    }
}
