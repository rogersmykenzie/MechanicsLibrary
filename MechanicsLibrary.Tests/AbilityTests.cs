using MechanicsLibrary.Core.Abilities;
using MechanicsLibrary.Core.Character;
using MechanicsLibrary.Core.Stats;

namespace MechanicsLibrary.Tests;

public class AbilityTests
{
    [Fact]
    public void ShouldExecuteAllEffects()
    {
        var mockEffect1 = new MockEffect { ID = "mock-1" };
        var mockEffect2 = new MockEffect { ID = "mock-2" };
        Ability a = new Ability
        {
            Name = "Test Ability",
            Range = 0,
            Tags = [],
            Effects = { mockEffect1, mockEffect2 },
        };

        a.Execute(
            new AbilityContext
            {
                User = new KillableCharacter
                {
                    Id = "MockChar",
                    Abilities = new List<Ability> { a },
                    Name = "Mr. Mock",
                    Stats = StatConfigs.GruntMelee,
                },
                Targets = new List<KillableCharacter>
                {
                    new KillableCharacter
                    {
                        Id = "MockChar2",
                        Abilities = new List<Ability> { },
                        Name = "Mr. Target",
                        Stats = StatConfigs.GruntMelee,
                    },
                },
            }
        );

        Assert.Equal(1, mockEffect1.TimesCalled);
        Assert.Equal(1, mockEffect2.TimesCalled);
    }

    [Fact]
    public void ShouldExecuteAllEffectsForAllTargets()
    {
        var mockEffect1 = new MockEffect { ID = "mock-1" };
        var mockEffect2 = new MockEffect { ID = "mock-2" };
        Ability a = new Ability
        {
            Name = "Test Ability",
            Range = 0,
            Tags = [],
            Effects = { mockEffect1, mockEffect2 },
        };

        a.Execute(
            new AbilityContext
            {
                User = new KillableCharacter
                {
                    Id = "MockChar",
                    Abilities = new List<Ability> { a },
                    Name = "Mr. Mock",
                    Stats = StatConfigs.GruntMelee,
                },
                Targets = new List<KillableCharacter>
                {
                    new KillableCharacter
                    {
                        Id = "MockChar2",
                        Abilities = new List<Ability> { },
                        Name = "Mr. Target",
                        Stats = StatConfigs.GruntMelee,
                    },
                    new KillableCharacter
                    {
                        Id = "MockChar3",
                        Abilities = new List<Ability> { },
                        Name = "Mr. Target 2",
                        Stats = StatConfigs.GruntMelee,
                    },
                },
            }
        );

        Assert.Equal(2, mockEffect1.TimesCalled);
        Assert.Equal(2, mockEffect2.TimesCalled);
    }
}
