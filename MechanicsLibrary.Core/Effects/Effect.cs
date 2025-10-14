using MechanicsLibrary.Core.Character;

namespace MechanicsLibrary.Core.Effects;

public interface IEffect
{
    string ID { get; }
    void Apply(EffectContext ctx);
}

public sealed class EffectContext
{
    public required KillableCharacter Originator { get; init; }
    public required KillableCharacter Reciever { get; init; }
    public Random RNG { get; init; } = new Random();
}
