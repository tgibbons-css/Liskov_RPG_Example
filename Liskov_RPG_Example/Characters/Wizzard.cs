using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov_RPG_Example.Characters
{
    class Wizzard : GenericPlayer
    {
        Wand wand;
        Broom broom;

        public override float move()
        {
            if (broom != null)
            {
                return broom.Speed;
            }
            else
            {
                return 20.0F;
            }
        }

        virtual public int castSpell(Wand wand)
        {
            int damage;
            if (wand.MagicCharge > 0)
            {
                damage = wand.GetDamage();
            } else
            {
                damage = 0;
            }
            return damage;
        }
    }
}
}
