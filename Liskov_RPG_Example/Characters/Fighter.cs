using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov_RPG_Example
{
    class Fighter : GenericPlayer
    {
        Weapon weaponInHand;
        Armor armorWorn;
        public override float move()
        {
            if (armorWorn.weight > 5.0)
            {
                return 10.0F;
            } else
            {
                return 20.0F;
            }
        }

        virtual public int attack(Weapon currentWeapon)
        {
            int damage = currentWeapon.GetDamage();
            return damage;
        }
    }
}
