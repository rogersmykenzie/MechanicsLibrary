using MechanicsLibrary.Core.Character;

namespace MechanicsLibrary.Core.AI;

// tell me who is up next, and let me be able to get the state of the battlefield, and I will tell you what to do
public interface IAI
{
    public void Act(AIContext ctx);
}

public class AIContext
{
    public required KillableCharacter[,] YourTeam { get; init; }
    public required KillableCharacter[,] TheirTeam { get; init; }
    public required KillableCharacter UpNext { get; init; }
}
