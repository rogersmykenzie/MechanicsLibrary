using MechanicsLibrary.Core.Status;

namespace MechanicsLibrary.Core.Effects;

public class BurnEffect : IEffect
{
    public string ID { get; } = "BURN_EFFECT";
    public required int Magnitude { get; set; }

    public void Apply(EffectContext ctx)
    {
        Burn burn = new Burn
        {
            Ctx = new StatusContext { Reciever = ctx.Reciever, Magnitude = Magnitude },
        };
        ctx.Reciever.ActiveModifiers.Add(burn);
    }
}
