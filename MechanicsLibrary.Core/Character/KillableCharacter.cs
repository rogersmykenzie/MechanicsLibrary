using MechanicsLibrary.Core.Stats;

namespace MechanicsLibrary.Core.Character;

public class KillableCharacter : Character
{
    public StatCollection Stats;
    public KillableCharacter(StatCollection stats)
    {
        Stats = stats;
    }
}