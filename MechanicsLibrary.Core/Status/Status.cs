using MechanicsLibrary.Core.Abilities;
using MechanicsLibrary.Core.Character;

namespace MechanicsLibrary.Core.Status;

public interface IStatus
{
    public StatusContext Ctx { get; init; }
    public void OnTurnStart();
}

public sealed class StatusContext
{
    public required KillableCharacter Reciever { get; init; }
    public required int Magnitude { get; init; }
}
