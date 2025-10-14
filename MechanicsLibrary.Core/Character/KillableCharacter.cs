using MechanicsLibrary.Core.Abilities;
using MechanicsLibrary.Core.Stats;
using MechanicsLibrary.Core.Status;

namespace MechanicsLibrary.Core.Character;

public class KillableCharacter : Character
{
    public required StatCollection Stats { get; init; }
    public required List<Ability> Abilities { get; init; }
    public List<IStatus> ActiveModifiers { get; init; } = new();
}
