using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov_RPG_Example
{
    public class Sword : Weapon
    {
        public Sword(int maxDamage, int attacksPerTurn, float weight) : base(maxDamage, attacksPerTurn, weight)
        {
        }

        public override int GetDamage()
        {
            Random rnd = new Random();
            int damage = rnd.Next(1, maxDamage);
            return damage;
        }
    }
}
