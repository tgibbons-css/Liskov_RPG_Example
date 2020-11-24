using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov_RPG_Example
{
    public class LeatherArmor : Armor
    {
        protected LeatherArmor(int protectionBonus, float weight) : base(protectionBonus, weight)
        {
        }

        public override int getProtectionFromBluntAttack()
        {
            return protectionBonus / 2;
        }

        public override int getProtectionFromSliceAttack()
        {
            return protectionBonus;
        }
    }
}
