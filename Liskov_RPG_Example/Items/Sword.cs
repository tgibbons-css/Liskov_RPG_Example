using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov_RPG_Example.Items
{
    public class Sword : Weapon
    {
        public override int GetDamage()
        {
            Random rnd = new Random();
            int damage = rnd.Next(1, maxDamage);
            return damage;
        }
    }
}
