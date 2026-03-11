using System;
using System.IO;

class Game
{
    private Player player;
    private Random random = new Random();

    // Starts the game by initializing the player, setting health, and entering the game loop.
    public void Start()
    {
        player = new Player();

        Console.Write("Enter your hero name: ");
        player.Name = Console.ReadLine();
        player.Health = 100;

        Console.WriteLine($"\nWelcome to the adventure, {player.Name}!");

        GameLoop();
    }

    // Main game loop that displays options and handles player actions until exit or death.
    private void GameLoop()
    {
        bool running = true;

        while (running && player.IsAlive())
        {
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Explore");
            Console.WriteLine("2. Rest");
            Console.WriteLine("3. Use Item");
            Console.WriteLine("4. Show Status");
            Console.WriteLine("5. Save Game");
            Console.WriteLine("6. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": Explore(); break;
                case "2": Rest(); break;
                case "3": player.UseItem(); break;
                case "4": player.ShowStatus(); break;
                case "5": SaveGame(); break;
                case "6": 
                running = false;
                Console.WriteLine($"\nThank you for playing, {player.Name}! See you next time.");
                break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }

        if (!player.IsAlive())
            Console.WriteLine("\nYou have fallen in battle. Game Over.");
    }

    // Simulates exploration with a random event: fight, find item, or nothing happens.
    private void Explore()
    {
        Console.WriteLine("\nYou venture into the wild...");
        int eventChance = random.Next(1, 4);

        if (eventChance == 1) FightMonster();
        else if (eventChance == 2) FindItem();
        else Console.WriteLine("Nothing happened during exploration.");
    }

    // Handles a battle between the player and a monster until one is defeated or the player runs away.
    private void FightMonster()
    {
        Monster monster = new Monster
        {
            Name = "Goblin",
            Health = 40,
            AttackPower = random.Next(10, 20)
        };

        Console.WriteLine($"\nA wild {monster.Name} appears!");

        while (monster.IsAlive() && player.IsAlive())
        {
            Console.WriteLine("\n1. Attack\n2. Run");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                int damage = random.Next(15, 25);
                Console.WriteLine($"You strike the monster for {damage} damage!");
                monster.TakeDamage(damage);

                if (monster.IsAlive())
                    monster.Attack(player);
            }
            else if (choice == "2")
            {
                Console.WriteLine("You escaped safely.");
                return;
            }
        }

        if (player.IsAlive())
        {
            Console.WriteLine("You defeated the monster!");
            FindItem();
        }
    }

    // Gives the player a health potion item and adds it to the inventory.
    private void FindItem()
    {
        Item potion = new Item("Health Potion", 20);
        player.AddItem(potion);
    }

    // Restores a fixed amount of health to the player.
    private void Rest()
    {
        Console.WriteLine("You rest and regain 15 health.");
        player.Health += 15;
    }

    // Saves the current player state (name, health, inventory count) to a text file.
    private void SaveGame()
    {
        string file = "savegame.txt";
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine(player.Name);
            writer.WriteLine(player.Health);
            writer.WriteLine(player.Inventory.Count);
        }

        Console.WriteLine("Game saved successfully.");
    }
}