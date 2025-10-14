using MechanicsLibrary.Core.Abilities;
using MechanicsLibrary.Core.Battle;
using MechanicsLibrary.Core.Character;
using MechanicsLibrary.Core.Stats;

namespace MechanicsLibrary.Sim.Demos;

public class TeamBuilderDemo
{
    public void Run()
    {
        var fs1 = new Hero
        {
            Abilities = new List<Ability> { AbilityCollection.ATTACK },
            Name = "Foot Soldier",
            Id = "fs1",
            Stats = StatConfigs.GruntMelee,
        };
        var fs2 = new Hero
        {
            Abilities = new List<Ability> { AbilityCollection.ATTACK },
            Name = "Foot Soldier",
            Id = "fs2",
            Stats = StatConfigs.GruntMelee,
        };
        var ch1 = new Hero
        {
            Abilities = new List<Ability> { AbilityCollection.SMITE, AbilityCollection.DEFEND },
            Name = "Chaplain",
            Id = "ch1",
            Stats = StatConfigs.TankyGruntMelee,
        };
        var ch2 = new Hero
        {
            Abilities = new List<Ability> { AbilityCollection.SMITE, AbilityCollection.DEFEND },
            Name = "Chaplain",
            Id = "ch2",
            Stats = StatConfigs.TankyGruntMelee,
        };
        var sm1 = new Hero
        {
            Abilities = new List<Ability> { AbilityCollection.ATTACK, AbilityCollection.CLEAVE },
            Name = "Samurai",
            Id = "Sm1",
            Stats = StatConfigs.MeleeAssassin,
        };
        var md1 = new Hero
        {
            Abilities = new List<Ability> { AbilityCollection.ATTACK, AbilityCollection.HEAL },
            Name = "Medic",
            Id = "Md1",
            Stats = StatConfigs.MeleeHealer,
        };
        var builder = new TeamBuilder
        {
            Candidates = new List<KillableCharacter> { fs1, fs2, ch1, ch2, sm1, md1 },
        };

        builder.PickCandidate(0, 0, 0);
        builder.PickCandidate(0, 0, 1);
        builder.PickCandidate(0, 0, 2);
        builder.PickCandidate(0, 1, 0);
        builder.PickCandidate(0, 1, 0);
        builder.PickCandidate(0, 1, 1);
        builder.PickCandidate(0, 1, 2);

        Console.WriteLine(builder.Team);
    }
}
