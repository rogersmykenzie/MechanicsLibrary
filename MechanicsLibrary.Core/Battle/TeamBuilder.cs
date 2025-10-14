using MechanicsLibrary.Core.Character;

namespace MechanicsLibrary.Core.Battle;

public class TeamBuilder
{
    public required List<KillableCharacter> Candidates { get; init; }
    public KillableCharacter?[,] Team { get; set; } =
        {
            { null, null, null },
            { null, null, null },
        }; // Defaults to 2x3 grid

    public void PickCandidate(KillableCharacter candidate, int row, int col)
    {
        if (!_isInBounds(row, col))
            throw new ArgumentOutOfRangeException("Position is out of bounds of the team grid.");
        if (!Candidates.Contains(candidate))
            throw new InvalidOperationException("Candidate is already in team.");

        KillableCharacter? existing = Team[row, col];
        if (existing != null) // swap candidates
        {
            Candidates.Add(existing);
            Candidates.Remove(candidate);
            Team[row, col] = candidate;
            return;
        }

        Team[row, col] = candidate;
        Candidates.Remove(candidate);
    }

    private bool _isInBounds(int row, int col)
    {
        return row >= 0 && row < Team.GetLength(0) && col >= 0 && col < Team.GetLength(1);
    }
}
