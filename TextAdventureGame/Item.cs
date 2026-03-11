struct Item
{
    public string Name;
    public int HealAmount;
   
    // Initializes a new Item with the specified name and heal amount.
    public Item(string name, int heal)
    {
        Name = name;
        HealAmount = heal;
    }
}