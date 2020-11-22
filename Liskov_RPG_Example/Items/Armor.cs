using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov_RPG_Example
{
    public abstract class Armor : InventoryItem
    {
        public int protectionBonus;

        public abstract int getProtectionFromBluntAttack();
        public abstract int getProtectionFromSliceAttack();
    }
}
