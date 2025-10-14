using MechanicsLibrary.Core.Character;

namespace MechanicsLibrary.Core.Battle;

public class Combat
{
    public KillableCharacter[,] HeroTeam { get; }
    public KillableCharacter[,] EnemyTeam { get; }

    public CombatTurnManager TurnManager { get; }

    public Combat(KillableCharacter[,] heroTeam, KillableCharacter[,] enemyTeam)
    {
        HeroTeam = heroTeam;
        EnemyTeam = enemyTeam;
        TurnManager = new CombatTurnManager(HeroTeam.Cast<KillableCharacter>().Concat(EnemyTeam.Cast<KillableCharacter>()).ToList()); // Pass flattened list of all combatants
    }
}

// CombatTurnManager

// Battle encompasses multiple combats that you can swap between