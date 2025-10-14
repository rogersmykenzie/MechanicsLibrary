using MechanicsLibrary.Core.Abilities;
using MechanicsLibrary.Core.Stats;

namespace MechanicsLibrary.Core.Character;

public class KillableCharacter : Character
{
    public StatCollection Stats;
    public required List<Ability> Abilities { get; init; }

    public KillableCharacter(StatCollection stats, List<Ability> abilities)
    {
        Stats = stats;
        Abilities = abilities;
    }
}
