using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov_RPG_Example
{
    public abstract class Weapon : InventoryItem
    {
        public int maxDamage;
        public int attacksPerTurn;

        public abstract int GetDamage();
    }
}
