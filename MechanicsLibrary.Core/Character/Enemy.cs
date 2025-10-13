using MechanicsLibrary.Core.Abilities;
using MechanicsLibrary.Core.Stats;

namespace MechanicsLibrary.Core.Character;

public class Enemy : KillableCharacter
{
    public List<Ability> Abilities { get; init; } = new();
    public Enemy() : base(new StatCollection()) {}
}