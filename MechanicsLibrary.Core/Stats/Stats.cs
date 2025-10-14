namespace MechanicsLibrary.Core.Stats;

public sealed class StatCollection
{
    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public int Armor { get; set; }
    public int Grit { get; set; }
    public int Strength { get; set; }
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
