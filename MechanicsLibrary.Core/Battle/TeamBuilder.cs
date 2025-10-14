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

    public void PickCandidate(int candidateIndex, int row, int col)
    {
        _validateIsInBounds(row, col);
        _validateCandidateIndex(candidateIndex);

        KillableCharacter candidate = Candidates[candidateIndex];

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

    public void RemoveCandidate(int row, int col)
    {
        _validateIsInBounds(row, col);
        KillableCharacter? candidate = Team[row, col];
        if (candidate == null)
        {
            throw new Exception("No candidate at that location.");
        }
        Candidates.Add(candidate);
    }

    public (KillableCharacter?, int) GetCandidateById(string id)
    {
        for (int i = 0; i < Candidates.Count; i++)
        {
            if (Candidates[i].Id == id)
            {
                return (Candidates[i], i);
            }
        }

        return (null, -1);
    }

    private void _validateIsInBounds(int row, int col)
    {
        bool isInBounds =
            row >= 0 && row < Team.GetLength(0) && col >= 0 && col < Team.GetLength(1);

        if (!isInBounds)
        {
            throw new ArgumentOutOfRangeException("Position is out of bounds of the team grid.");
        }
    }

    private void _validateCandidateIndex(int candidateIndex)
    {
        if (Candidates.Count < candidateIndex)
        {
            throw new ArgumentOutOfRangeException(
                "Position is out of bounds of the candidate list."
            );
        }
    }
}
