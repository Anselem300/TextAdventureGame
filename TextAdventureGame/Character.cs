abstract class Character
{
    public string Name { get; set; }
    public int Health { get; set; }

    public virtual void TakeDamage(int amount)
    {
        Health -= amount;
    }

    public bool IsAlive()
    {
        return Health > 0;
    }
}