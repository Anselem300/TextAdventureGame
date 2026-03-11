abstract class Character
{
    public string Name { get; set; }
    public int Health { get; set; }

    // Reduces the character's health by the specified damage amount.
    public virtual void TakeDamage(int amount)
    {
        Health -= amount;
    }

    // Checks if the character is still alive (health greater than zero).
    public bool IsAlive()
    {
        return Health > 0;
    }
}