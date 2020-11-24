using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov_RPG_Example
{
    public class Armor : InventoryItem
    {
        public int protectionBonus;

        protected Armor(int protectionBonus, float weight) : base(weight)
        {
            this.protectionBonus = protectionBonus;
        }

        public virtual int getProtectionFromBluntAttack()
        {
            return protectionBonus;
        }
        public virtual int getProtectionFromSliceAttack()
        {
            return protectionBonus;
        }
    }
}
