using MechanicsLibrary.Core.Abilities;
using MechanicsLibrary.Core.AI;
using MechanicsLibrary.Core.Battle;
using MechanicsLibrary.Core.Character;
using MechanicsLibrary.Core.Stats;

namespace MechanicsLibrary.Sim.Demos;

public class TurnBattleDemo : IRunnableScenario
{
    public void Run()
    {
        Hero Benson = new Hero
        {
            Name = "Benson",
            Abilities = new List<Ability>
            {
                AbilityCollection.ATTACK,
                AbilityCollection.SMITE,
                AbilityCollection.DEFEND,
                AbilityCollection.CLEAVE,
            },
            Stats = new StatCollection
            {
                MaxHealth = 100,
                Health = 100,
                Armor = 25,
                Grit = 0,
                Strength = 15,
                Speed = 25,
            },
        };
        Enemy Pig = new Enemy
        {
            Name = "Pig",
            Abilities = new List<Ability> { AbilityCollection.ATTACK, AbilityCollection.HEAL },
            Stats = new StatCollection
            {
                MaxHealth = 10,
                Health = 10,
                Armor = 10,
                Grit = 0,
                Strength = 10,
                Speed = 10,
            },
        };
        Enemy Pig2 = new Enemy
        {
            Name = "Pig",
            Abilities = new List<Ability> { AbilityCollection.ATTACK, AbilityCollection.HEAL },
            Stats = new StatCollection
            {
                MaxHealth = 10,
                Health = 10,
                Armor = 10,
                Grit = 0,
                Strength = 10,
                Speed = 10,
            },
        };
        Enemy Pig3 = new Enemy
        {
            Name = "Pig",
            Abilities = new List<Ability> { AbilityCollection.ATTACK, AbilityCollection.HEAL },
            Stats = new StatCollection
            {
                MaxHealth = 10,
                Health = 10,
                Armor = 10,
                Grit = 0,
                Strength = 10,
                Speed = 10,
            },
        };

        Hero[,] heroTeam = new Hero[,]
        {
            { Benson },
        };

        Enemy[,] enemyTeam = new Enemy[,]
        {
            { Pig, Pig2, Pig3 },
        };

        Combat combat = new Combat(heroTeam, enemyTeam);

        BasicAI AI = new BasicAI();
        Benson
            .Abilities[0]
            .Execute(
                new AbilityContext
                {
                    Targets = new List<KillableCharacter> { Pig },
                    User = Benson,
                }
            );

        combat.TurnManager.NextTurn();

        AI.Act(
            new AIContext
            {
                YourTeam = combat.EnemyTeam,
                TheirTeam = combat.HeroTeam,
                UpNext = combat.TurnManager.CurrentTurn(),
            }
        );

        combat.TurnManager.NextTurn();

        AI.Act(
            new AIContext
            {
                YourTeam = combat.EnemyTeam,
                TheirTeam = combat.HeroTeam,
                UpNext = combat.TurnManager.CurrentTurn(),
            }
        );

        combat.TurnManager.NextTurn();

        combat.Debug();
    }
}
