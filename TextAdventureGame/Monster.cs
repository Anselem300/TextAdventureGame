using System;

class Monster : Character
{
    public int AttackPower { get; set; }

    public void Attack(Player player)
    {
        Console.WriteLine($"{Name} attacks and deals {AttackPower} damage!");
        player.TakeDamage(AttackPower);
    }
}