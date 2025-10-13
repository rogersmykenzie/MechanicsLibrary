using MechanicsLibrary.Core.Effects;

namespace MechanicsLibrary.Core.Abilities;

public static class AbilityCollection
{
    public static Ability ATTACK = new Ability("ATTACK", new List<IEffect> { new DamageEffect(true) { Magnitude = 10 } });
}