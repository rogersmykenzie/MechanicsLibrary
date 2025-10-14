using MechanicsLibrary.Core.Effects;
using MechanicsLibrary.Core.Stats;

namespace MechanicsLibrary.Core.Abilities;

public static class AbilityCollection
{
    // Offensive Abilities
    public static Ability ATTACK = new Ability
    {
        Name = "ATTACK",
        Effects = new List<IEffect> { new DamageEffect() { Magnitude = 10 } },
        Range = 3,
        Tags = [Tag.Offensive],
    };
    public static Ability SMITE = new Ability
    {
        Name = "SMITE",
        Effects = new List<IEffect> { new PureDamageEffect() { Magnitude = 3 } },
        Range = 5,
        Tags = [],
    };
    public static Ability CLEAVE = new Ability
    {
        Name = "CLEAVE",
        Effects = new List<IEffect> { new DamageEffect() { Magnitude = 4 } },
        Range = 3,
        Tags = [],
    };

    // Buffs
    public static Ability DEFEND = new Ability
    {
        Name = "DEFEND",
        Effects = new List<IEffect>
        {
            new StatChangeEffect() { Type = StatType.Armor, Magnitude = 50 },
        },
        Range = 500,
        Tags = [],
    };
    public static Ability HEAL = new Ability
    {
        Name = "HEAL",
        Effects = new List<IEffect>
        {
            new StatChangeEffect() { Type = StatType.Health, Magnitude = 10 },
        },
        Range = 3,
        Tags = [Tag.Heal],
    };
}
