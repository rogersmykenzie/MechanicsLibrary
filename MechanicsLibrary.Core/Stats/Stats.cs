namespace MechanicsLibrary.Core.Stats;

public sealed class StatCollection
{
    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public int Armor { get; set; }
    public int Grit { get; set; }
    public int Strength { get; set; }
    public int Magic { get; set; }
    public int Speed { get; set; }
}

public enum StatType
{
    Health,
    MaxHealth,
    Armor,
    Grit,
    Strength,
    Speed,
}

// Common configs of stats
public static class StatConfigs
{
    public static StatCollection GruntMelee = new StatCollection
    {
        Health = 15,
        MaxHealth = 15,
        Armor = 10,
        Grit = 0,
        Strength = 15,
        Speed = 25,
    };

    public static StatCollection TankyGruntMelee = new StatCollection
    {
        Health = 30,
        MaxHealth = 30,
        Armor = 30,
        Grit = 1,
        Strength = 15,
        Speed = 10,
    };

    public static StatCollection MeleeAssassin = new StatCollection
    {
        Health = 20,
        MaxHealth = 20,
        Armor = 15,
        Grit = 1,
        Strength = 30,
        Speed = 50,
    };

    public static StatCollection MeleeHealer = new StatCollection
    {
        Health = 20,
        MaxHealth = 20,
        Armor = 20,
        Grit = 0,
        Strength = 10,
        Speed = 25,
    };

    public static StatCollection FireMage = new StatCollection
    {
        Health = 15,
        MaxHealth = 15,
        Armor = 5,
        Grit = 1,
        Magic = 30,
        Speed = 30,
    };

    public static StatCollection LowHealth = new StatCollection { Health = 2, MaxHealth = 10 };

    public static StatCollection TargetDummy = new StatCollection
    {
        Health = 10000,
        MaxHealth = 10000,
        Armor = 0,
        Grit = 0,
        Strength = 0,
        Speed = 0,
    };
}
