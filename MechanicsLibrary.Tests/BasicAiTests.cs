using MechanicsLibrary.Core.Abilities;
using MechanicsLibrary.Core.AI;
using MechanicsLibrary.Core.Character;
using MechanicsLibrary.Core.Stats;

namespace MechanicsLibrary.Tests;

public class BasicAITests
{
    [Fact]
    public void ShouldHealIfLowHealth()
    {
        var ai = new BasicAI();
        var heal = new MockAbility
        {
            Range = 0,
            Name = "Mock Heal",
            Tags = [Tag.Heal],
            Effects = { },
        };
        var enemy = new KillableCharacter
        {
            Abilities = new List<Ability> { AbilityCollection.ATTACK, heal },
            Name = "Low Health Enemy",
            Stats = StatConfigs.LowHealth,
        };
        var target = new KillableCharacter
        {
            Abilities = new List<Ability> { },
            Name = "Juicy Target",
            Stats = StatConfigs.GruntMelee,
        };

        ai.Act(
            new AIContext
            {
                YourTeam = new KillableCharacter[,]
                {
                    { enemy },
                },
                TheirTeam = new KillableCharacter[,]
                {
                    { target },
                },
                UpNext = enemy,
            }
        );

        Assert.Equal(1, heal.TimesCalled);
    }
}
