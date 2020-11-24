using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov_RPG_Example
{
    public class Weapon : InventoryItem
    {
        public int maxDamage;
        public int attacksPerTurn;

        public Weapon(int maxDamage, int attacksPerTurn, float weight) : base(weight)
        {
            this.maxDamage = maxDamage;
            this.attacksPerTurn = attacksPerTurn;
        }

        new public float Weight
        {
            get { return weight; }
            set
            {
                if (value >= 10.0)
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Weapon weight must be 10 or more");
                }
            }
        }
        public virtual int GetDamage()
        {
            return maxDamage;

        }
    }
}
