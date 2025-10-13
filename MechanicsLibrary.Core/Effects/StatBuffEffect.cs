using MechanicsLibrary.Core.Stats;

namespace MechanicsLibrary.Core.Effects;

public class StatChangeEffect : IEffect
{
    public string ID { get; } = "STAT_CHANGE_EFFECT";
    public required int Magnitude { get; init; }
    public required StatType Type { get; init; }
    private bool _isDebug;

    public StatChangeEffect(bool isDebug)
    {
        _isDebug = isDebug;
    }

    public void Apply(EffectContext ctx)
    {
        if (_isDebug)
        {
            Console.WriteLine("Casting " + ID);
            Console.WriteLine("Changing " + Type + " By " + Magnitude);
        }
        switch(Type)
        {
            case StatType.Health:
                ctx.Reciever.Stats.Health += Magnitude;
                if (_isDebug) Console.WriteLine("Reciever Health at " + ctx.Reciever.Stats.Health);
                break;
            case StatType.Strength:
                ctx.Reciever.Stats.Strength += Magnitude;
                if (_isDebug) Console.WriteLine("Reciever Strength at " + ctx.Reciever.Stats.Strength);
                break;
            case StatType.Armor:
                ctx.Reciever.Stats.Armor += Magnitude;
                if (_isDebug) Console.WriteLine("Reciever Armor at " + ctx.Reciever.Stats.Armor);
                break;
            case StatType.Grit:
                ctx.Reciever.Stats.Grit += Magnitude;
                if (_isDebug) Console.WriteLine("Reciever Grit at " + ctx.Reciever.Stats.Grit);
                break;
        }
    }
}