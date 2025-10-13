using MechanicsLibrary.Core.Abilities;
using MechanicsLibrary.Core.Stats;

namespace MechanicsLibrary.Core.Character;

public class Hero : KillableCharacter
{
    public List<Ability> Abilities { get; init; } = new();
    public Hero() : base(new StatCollection()) { }
}