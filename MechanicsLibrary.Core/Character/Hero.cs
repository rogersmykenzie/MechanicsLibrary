using MechanicsLibrary.Core.Abilities;
using MechanicsLibrary.Core.Stats;

namespace MechanicsLibrary.Core.Character;

public class Hero : KillableCharacter
{
    public Hero()
        : base(new StatCollection(), new List<Ability>()) { }
}
