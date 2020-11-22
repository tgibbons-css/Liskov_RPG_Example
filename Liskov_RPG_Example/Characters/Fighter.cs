using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov_RPG_Example
{
    class Fighter : GenericPlayer
    {
        Weapon weaponInLeftHand;
        Weapon weaponInRightHand;

        public override float move()
        {
            if (CurrentArmor.weight > 5.0)
            {
                return 10.0F;
            } else
            {
                return 20.0F;
            }
        }

        virtual public int attack(Weapon weapon)
        {
            int damage = weapon.GetDamage();
            return damage;
        }
    }
}
