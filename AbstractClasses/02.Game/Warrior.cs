using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Game
{
    public class Warrior : Character
    {
        public  int Armor { get; set; }
        public override string Attack()
        {
            return "Warrior [име] атакува с меч и нанася [сила на атаката] щети!".Replace("[име]", Name).Replace("[сила на атаката]", AttackPower.ToString());
        }
        public void TakeDamage(int damage)
        {
            int realDamage = damage - Armor;
            if (realDamage < 0)
            {
                realDamage = 0;
            }
            Health -= realDamage;
        }
    }
}
