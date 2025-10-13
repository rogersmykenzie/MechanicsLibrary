using MechanicsLibrary.Core.Character;
using MechanicsLibrary.Core.Effects;

namespace MechanicsLibrary.Core.Abilities;

public class Ability : IAbility
{
    public string Name { get; }
    public List<IEffect> Effects { get; }

    public Ability(string name, List<IEffect> effects)
    {
        Name = name;
        Effects = effects;
    }

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
    List<IEffect> Effects { get; }
    void Execute(AbilityContext ctx);
}