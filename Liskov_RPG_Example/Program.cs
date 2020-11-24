using System;

namespace Liskov_RPG_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Wizzard George = new Wizzard();

            George.AddItemToBackpack(new Weapon(1, 1, 4.0F));
            George.AddItemToBackpack(new Weapon(1, 1, 14.0F));

            George.reduceItemWeight();


        }
    }
}
