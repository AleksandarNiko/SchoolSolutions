using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Game
{
    public abstract class Character
    {
        private string name;
        private int health;
        private int attackPower;

        public string Name { get => name; set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            } 
        }

        public int Health { get => health; set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Health cannot be negative");
                }
                health = value;
            } 
        }

        public int AttackPower { get => attackPower; set 
            {
                if (value < 5)
                {
                    throw new ArgumentException("Attack power cannot be less than 5");
                }
                attackPower = value;
            } 
        }

        public abstract string Attack();

        public void TakeDamage(int damage)
        {
            if (damage < 0)
            {
                throw new ArgumentException("Damage cannot be negative");
            }
            Health -= damage;
        }

        public bool IsAlive()
        {
            return Health > 0;
        }

    }
}
