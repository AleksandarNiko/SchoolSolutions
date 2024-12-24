using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Game
{
    public class Mage : Character
    {
        public int Mana { get; set; }
        public override string Attack()
        {
            return "Mage [име] атакува с магия и нанася [сила на атаката] щети!".Replace("[име]", Name).Replace("[сила на атаката]", AttackPower.ToString());
        }

        public string CastSpell(string spellName)
        {
            if (Mana < 10)
            {
                return "Not enough mana!";
            }
            Mana -= 10;
            return $"Mage {Name} използва заклинание {spellName}!";
        }
    }
}
