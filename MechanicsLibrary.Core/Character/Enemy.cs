using MechanicsLibrary.Core.Abilities;
using MechanicsLibrary.Core.Stats;

namespace MechanicsLibrary.Core.Character;

public class Enemy : KillableCharacter
{
    public required List<Ability> Abilities { get; init; }
    public Enemy() : base(new StatCollection()) { }
    
    public void Debug()
    {
        Console.WriteLine("Health at " + Stats.Health);
    }
}