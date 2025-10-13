namespace MechanicsLibrary.Core.Stats;

public sealed class StatCollection
{
    public int Health { get; set; }
    public int Armor { get; set; }
    public int Grit { get; set; }
    public int Strength { get; set; }

    public StatCollection(int health = 0, int armor = 0, int grit = 0, int strength = 0)
    {
        Health = health;
        Armor = armor;
        Grit = grit;
        Strength = strength;
    }
}

public enum StatType
{
    Health,
    Armor,
    Grit,
    Strength,
}