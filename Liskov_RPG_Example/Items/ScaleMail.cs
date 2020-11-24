using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov_RPG_Example
{
    public class ScaleMail : Armor
    {
        protected ScaleMail(int protectionBonus, float weight) : base(protectionBonus, weight)
        {
        }
        public override int getProtectionFromBluntAttack()
        {
            return protectionBonus;
        }

        public override int getProtectionFromSliceAttack()
        {
            return protectionBonus / 2;
        }
    }
}
