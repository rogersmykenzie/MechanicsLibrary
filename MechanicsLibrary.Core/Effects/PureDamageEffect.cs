namespace MechanicsLibrary.Core.Effects;

public class PureDamageEffect : IEffect
{
    public string ID { get; } = "PURE_DAMAGE_EFFECT";
    public int Magnitude { get; init; }
    private bool _isDebug { get; init; }

    public PureDamageEffect(bool isDebug = false)
    {
        _isDebug = isDebug;
    }

    public void Apply(EffectContext ctx)
    {
        if (_isDebug)
        {
            Console.WriteLine("Casting " + ID);
            Console.WriteLine("Dealing " + Magnitude + " Pure Damage");
        }
        ctx.Reciever.Stats.Health -= Magnitude;
        if (_isDebug)
            Console.WriteLine("Receiver Health Lowered to " + ctx.Reciever.Stats.Health);
    }
}
