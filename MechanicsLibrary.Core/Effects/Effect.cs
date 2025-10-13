using MechanicsLibrary.Core.Character;

namespace MechanicsLibrary.Core.Effects;

public interface IEffect
{
    string ID { get; }
    void Apply(EffectContext ctx);
}

public sealed class EffectContext
{
    public KillableCharacter Originator { get; }
    public KillableCharacter Reciever { get; }

    public EffectContext(KillableCharacter originator, KillableCharacter reciever)
    {
        Originator = originator;
        Reciever = reciever;
    }
}