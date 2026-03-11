using System;

class Monster : Character
{
    public int AttackPower { get; set; }

    // Attacks the specified player, dealing damage equal to the monster's AttackPower.
    public void Attack(Player player)
    {
        Console.WriteLine($"{Name} attacks and deals {AttackPower} damage!");
        player.TakeDamage(AttackPower);
    }
}