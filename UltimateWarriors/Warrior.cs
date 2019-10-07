using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateWarriors
{
    class Warrior
    {
        public string Name { get; set; }
        public int Health { get; set; } = 0;
        public int MaxAttack { get; set; } = 0;
  
        public int MaxBlock { get; set; } = 0;

        public Random rand = new Random();

        

        public Warrior(string name, int health, int maxAttack, int maxBlock)
        {
            this.Name = name;
            this.Health = health;
            this.MaxAttack = maxAttack;
            this.MaxBlock = maxBlock;
        }

        public int Attack()
        {
            return rand.Next(1, MaxAttack);
        }
        public int Block()
        {
           return rand.Next(1, MaxBlock);
        }
    }

   
}
