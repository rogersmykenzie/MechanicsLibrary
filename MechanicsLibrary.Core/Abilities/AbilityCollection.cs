using MechanicsLibrary.Core.Effects;
using MechanicsLibrary.Core.Stats;
using MechanicsLibrary.Core.Status;

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

    public static Ability IDLE = new Ability
    {
        Name = "IDLE",
        Effects = new List<IEffect> { new DamageEffect() { Magnitude = 0 } },
        Range = 0,
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

    // Heals
    // heals a large amount but applies burn to self
    public static Ability INFERNAL_GAMBIT = new Ability
    {
        Name = "INFERNAL_GAMBIT",
        Effects = new List<IEffect>
        {
            new BurnEffect { Magnitude = 5 },
            new StatChangeEffect() { Type = StatType.Health, Magnitude = 15 },
        },
        Range = 3,
        Tags = [Tag.Heal, Tag.Fire],
    };

    // Magic
    public static Ability FIREBALL = new Ability
    {
        Name = "FIREBALL",
        Effects = new List<IEffect> { new FireEffect { Magnitude = 8 } },
        Range = 5,
        Tags = [Tag.Offensive, Tag.Fire, Tag.Magic],
    };
}
