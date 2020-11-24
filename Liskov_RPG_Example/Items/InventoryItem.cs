using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov_RPG_Example
{
    public class InventoryItem : Item
    {
        protected float weight;
        public string inventorySprite;

        public float Weight {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                } else
                {
                    throw new ArgumentOutOfRangeException("value", "Item weight must be positive and nonzero");
                }
            }
        }

        public InventoryItem(float weight)
        {
            this.Weight = weight;
        }
    }
}
