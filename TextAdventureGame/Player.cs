using System;
using System.Collections.Generic;

class Player : Character
{
    public List<Item> Inventory = new List<Item>();

    public void ShowStatus()
    {
        Console.WriteLine("\n==== PLAYER STATUS ====");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Health: " + Health);
        Console.WriteLine("Inventory Count: " + Inventory.Count);
        Console.WriteLine("========================\n");
    }

    public void AddItem(Item item)
    {
        Inventory.Add(item);
        Console.WriteLine("You received: " + item.Name);
    }

    public void UseItem()
    {
        if (Inventory.Count == 0)
        {
            Console.WriteLine("No items available.");
            return;
        }

        Console.WriteLine("\nInventory:");
        for (int i = 0; i < Inventory.Count; i++)
            Console.WriteLine($"{i + 1}. {Inventory[i].Name}");

        Console.Write("Select item number: ");
        int choice = Convert.ToInt32(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < Inventory.Count)
        {
            Item item = Inventory[choice];
            Health += item.HealAmount;
            Console.WriteLine($"You used {item.Name} and recovered {item.HealAmount} health.");
            Inventory.RemoveAt(choice);
        }
        else
        {
            Console.WriteLine("Invalid item.");
        }
    }
}