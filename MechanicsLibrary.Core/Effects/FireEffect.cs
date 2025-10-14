using MechanicsLibrary.Core.Status;

namespace MechanicsLibrary.Core.Effects;

/*
    Fire Effect
    Deals Base Magic Damage
    Magic % Increases Damage Dealt
    Base 20% Chance to Burn
*/
public class FireEffect : IEffect
{
    public string ID { get; } = "FIRE_EFFECT";
    public int Magnitude { get; init; }

    public void Apply(EffectContext ctx)
    {
        int Intelligence = ctx.Originator.Stats.Magic;
        float OutgoingDmg = (1 + (Intelligence / 100f)) * Magnitude;
        float PercentMitigatedDmg = OutgoingDmg * (1 - (ctx.Reciever.Stats.Armor / 100f));
        int FlatMitigatedDmg = (int)Math.Round(PercentMitigatedDmg - ctx.Reciever.Stats.Grit);
        ctx.Reciever.Stats.Health -= FlatMitigatedDmg;
        if (ctx.RNG.Next(0, 100) < 20)
        {
            ctx.Reciever.ActiveModifiers.Add(
                new Burn
                {
                    Ctx = new StatusContext
                    {
                        Reciever = ctx.Reciever,
                        Magnitude = (int)Math.Round(FlatMitigatedDmg * 0.5), // Burn for 50% of initial damage
                    },
                }
            );
        }
    }
}
