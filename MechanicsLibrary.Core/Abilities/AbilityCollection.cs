using MechanicsLibrary.Core.Effects;
using MechanicsLibrary.Core.Stats;

namespace MechanicsLibrary.Core.Abilities;

public static class AbilityCollection
{
    // Offensive Abilities
    public static Ability ATTACK = new Ability { Name = "ATTACK", Effects = new List<IEffect> { new DamageEffect(true) { Magnitude = 10 } } };
    public static Ability SMITE = new Ability { Name = "SMITE", Effects = new List<IEffect> { new PureDamageEffect(true) { Magnitude = 3 } } };

    // Buffs
    public static Ability DEFEND = new Ability { Name = "Defend", Effects = new List<IEffect> { new StatChangeEffect(true) { Type = StatType.Armor, Magnitude = 50 } } };
}