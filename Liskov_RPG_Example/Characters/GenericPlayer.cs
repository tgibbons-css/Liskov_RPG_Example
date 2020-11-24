using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov_RPG_Example
{
    public abstract class GenericPlayer
    {
        public string playerName;
        public string playerClass;

        private int strength;
        public int Strength { get => strength; set => strength = value; }

        private int dexterity;
        public int Dexterity { get => dexterity; set => dexterity = value; }

        private Armor currentArmor;
        public void wearArmor(Armor newArmor)
        {
            currentArmor = newArmor;
        }
        public Armor CurrentArmor { get => currentArmor;}

        List<InventoryItem> backpackItems = new List<InventoryItem>();

        public void AddItemToBackpack (InventoryItem item)
        {
            backpackItems.Add(item);
        }
        public abstract float move();

        public void reduceItemWeight()
        {
            foreach (InventoryItem item in backpackItems)
            {
                float itemWeight = item.Weight;
                item.Weight = 1;
            }
        }
    }
}
