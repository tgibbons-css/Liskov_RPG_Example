using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov_RPG_Example
{
    public abstract class GenericPlayer
    {
        public string playerName;
        public string playerClass;

        public int strength;
        public int dexterity;

        List<InventoryItem> backpackItems = new List<InventoryItem>;

        public abstract float move();
    }
}
