using MechanicsLibrary.Core.Character;
using MechanicsLibrary.Core.Effects;

namespace MechanicsLibrary.Core.Abilities;

public class Ability : IAbility
{
    public string Name { get; init; } = "";
    public List<IEffect> Effects { get; init; } = new();
    public required Tag[] Tags { get; init; }
    public required int Range { get; init; } // Remove Range

    public void Execute(AbilityContext ctx)
    {
        foreach (KillableCharacter target in ctx.Targets)
        {
            foreach (IEffect effect in Effects)
            {
                effect.Apply(new EffectContext(ctx.User, target));
            }
        }
    }
}

public interface IAbility
{
    string Name { get; }
    Tag[] Tags { get; }
    List<IEffect> Effects { get; }
    void Execute(AbilityContext ctx);
}
