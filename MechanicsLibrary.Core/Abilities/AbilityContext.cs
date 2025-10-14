using MechanicsLibrary.Core.Character;

namespace MechanicsLibrary.Core.Abilities;

public sealed class AbilityContext
{
    public required KillableCharacter User { get; init; }
    public required List<KillableCharacter> Targets { get; init; }
}
