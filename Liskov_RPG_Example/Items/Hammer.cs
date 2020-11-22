using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov_RPG_Example.Items
{
    class Hammer : Weapon
    {
        public override int GetDamage()
        {
            Random rnd = new Random();
            int damage = rnd.Next(1, maxDamage/2) + rnd.Next(1, maxDamage / 2);
            return damage;
        }
    }
}
