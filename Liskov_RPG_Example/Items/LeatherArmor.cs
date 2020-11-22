using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov_RPG_Examples
{
    public class LeatherArmor : Armor
    {
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
