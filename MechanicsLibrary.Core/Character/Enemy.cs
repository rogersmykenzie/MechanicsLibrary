using MechanicsLibrary.Core.Abilities;
using MechanicsLibrary.Core.Stats;

namespace MechanicsLibrary.Core.Character;

public class Enemy : KillableCharacter
{
    public Enemy()
        : base(new StatCollection(), new List<Ability>()) { }

    public void Debug()
    {
        Console.WriteLine("Health at " + Stats.Health);
    }
}
