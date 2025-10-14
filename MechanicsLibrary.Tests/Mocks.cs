using MechanicsLibrary.Core.Abilities;
using MechanicsLibrary.Core.Effects;

namespace MechanicsLibrary.Tests;

public class MockEffect : IEffect
{
    public int TimesCalled { get; set; } = 0;
    public required string ID { get; init; }

    public void Apply(EffectContext ctx)
    {
        TimesCalled++;
    }
}

public class MockAbility : Ability
{
    public int TimesCalled { get; set; } = 0;

    public override void Execute(AbilityContext ctx)
    {
        TimesCalled++;
        base.Execute(ctx);
    }
}
