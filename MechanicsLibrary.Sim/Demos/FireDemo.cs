using MechanicsLibrary.Core.Abilities;
using MechanicsLibrary.Core.Battle;
using MechanicsLibrary.Core.Character;
using MechanicsLibrary.Core.Stats;

namespace MechanicsLibrary.Sim.Demos;

public class FireDemo : IRunnableScenario
{
    public void Run()
    {
        var hero = new Hero
        {
            Name = "Hero",
            Stats = StatConfigs.FireMage,
            Abilities = new List<Ability> { AbilityCollection.FIREBALL },
        };

        var target = new Enemy
        {
            Name = "Target Dummy",
            Stats = StatConfigs.TargetDummy,
            Abilities = new List<Ability> { AbilityCollection.IDLE },
        };

        var combat = new Combat(
            new Hero[,]
            {
                { hero },
            },
            new Enemy[,]
            {
                { target },
            }
        );

        Console.WriteLine("=== Initial State ===");
        hero.Abilities[0]
            .Execute(
                new AbilityContext
                {
                    User = hero,
                    Targets = new List<KillableCharacter> { target },
                }
            );
        combat.TurnManager.NextTurn();
    }
}
