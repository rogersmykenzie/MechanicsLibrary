namespace MechanicsLibrary.Core.Effects;

public class DamageEffect : IEffect
{
    public string ID { get; } = "DAMAGE_EFFECT";
    public int Magnitude { get; init; }
    private bool _isDebug { get; init; }

    public DamageEffect(bool isDebug = false)
    {
        _isDebug = isDebug;
    }

    public void Apply(EffectContext ctx)
    {
        if (_isDebug) Console.WriteLine("Casting " + ID);
        int Strength = ctx.Originator.Stats.Strength;
        if (_isDebug) Console.WriteLine("Originator Strength = " + Strength);
        float OutgoingDmg = (1 + (Strength / 100f)) * Magnitude;
        if (_isDebug) Console.WriteLine("Outgoing Damage = " + OutgoingDmg);
        float PercentMitigatedDmg = OutgoingDmg * (1 - (ctx.Reciever.Stats.Armor / 100f));
        if (_isDebug) Console.WriteLine("Damage After Percent Mitigation = " + PercentMitigatedDmg);
        int FlatMitigatedDmg = (int)Math.Round(PercentMitigatedDmg - ctx.Reciever.Stats.Grit);
        if (_isDebug) Console.WriteLine("Damage after flat mitigation = " + FlatMitigatedDmg);
        ctx.Reciever.Stats.Health -= FlatMitigatedDmg;
        if (_isDebug) Console.WriteLine("New health for reciever = " + ctx.Reciever.Stats.Health);
    }
}

// if strength is 10, and magnitude is 10, then they should deal 11 damage
/**
 strength / 100f + 1

 if dmg is 10 and armor is 60 then they should only take 40% damage aka 4
 10 * (1 - (60 / 100))

*/