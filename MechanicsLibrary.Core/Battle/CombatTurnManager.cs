using MechanicsLibrary.Core.Character;

namespace MechanicsLibrary.Core.Battle;

public class CombatTurnManager
{
    public Queue<KillableCharacter> CombatantQueue { get; } = new Queue<KillableCharacter>();

    public CombatTurnManager(List<KillableCharacter> combatants)
    {
        combatants.Sort((a, b) => b.Stats.Speed.CompareTo(a.Stats.Speed)); // Higher speed goes first;
        foreach (KillableCharacter c in combatants)
        {
            CombatantQueue.Enqueue(c);
            Console.WriteLine(c.Name + " has " + c.Stats.Speed + " speed");
        }
    }

    public KillableCharacter CurrentTurn()
    {
        return CombatantQueue.Peek();
    }

    // Steps to next turn and returns the next combatant
    public KillableCharacter NextTurn()
    {
        KillableCharacter temp = CombatantQueue.Dequeue();
        CombatantQueue.Enqueue(temp);
        return CombatantQueue.Peek();
    }

    public void Debug()
    {
        Console.WriteLine("Turn order:");
        foreach (KillableCharacter c in CombatantQueue)
        {
            Console.WriteLine(c.Name);
        }
    }
}

// calculate turn order
// tell you who's turn is next
