using MechanicsLibrary.Core.Character;

namespace MechanicsLibrary.Core.Battle;

public class Combat
{
    public Hero[,] HeroTeam { get; }
    public Enemy[,] EnemyTeam { get; }

    public CombatTurnManager TurnManager { get; }

    public Combat(Hero[,] heroTeam, Enemy[,] enemyTeam)
    {
        HeroTeam = heroTeam;
        EnemyTeam = enemyTeam;
        TurnManager = new CombatTurnManager(
            HeroTeam.Cast<KillableCharacter>().Concat(EnemyTeam.Cast<KillableCharacter>()).ToList()
        ); // Pass flattened list of all combatants
    }

    public void Debug()
    {
        Console.WriteLine("Heroes:");
        foreach (Hero h in HeroTeam)
        {
            if (h != null)
                Console.WriteLine("- " + h.Name + " at " + h.Stats.Health + " health");
        }
        Console.WriteLine("Enemies:");
        foreach (Enemy e in EnemyTeam)
        {
            if (e != null)
                Console.WriteLine("- " + e.Name + " at " + e.Stats.Health + " health");
        }
        TurnManager.Debug();
    }
}

// CombatTurnManager

// Battle encompasses multiple combats that you can swap between
