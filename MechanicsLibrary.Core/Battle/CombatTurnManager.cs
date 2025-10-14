using MechanicsLibrary.Core.Character;

namespace MechanicsLibrary.Core.Battle;

public class CombatTurnManager
{
    public Queue<KillableCharacter> CombatantQueue { get; set; } = new Queue<KillableCharacter>();

    public CombatTurnManager(List<KillableCharacter> combatants)
    {
        combatants.Sort((a, b) => b.Stats.Speed.CompareTo(a.Stats.Speed)); // Higher speed goes first;
        foreach (KillableCharacter c in combatants)
        {
            CombatantQueue.Enqueue(c);
            // Console.WriteLine(c.Name + " has " + c.Stats.Speed + " speed");
        }
    }

    public KillableCharacter CurrentTurn()
    {
        return CombatantQueue.Peek();
    }

    // Steps to next turn and returns the next combatant
    public KillableCharacter NextTurn()
    {
        _cleanUpDead();
        KillableCharacter temp = CombatantQueue.Dequeue();
        CombatantQueue.Enqueue(temp);
        CombatantQueue.Peek().ActiveModifiers.ForEach(m => m.OnTurnStart());
        return CombatantQueue.Peek();
    }

    private void _cleanUpDead()
    {
        Queue<KillableCharacter> newQueue = new Queue<KillableCharacter>();
        int count = CombatantQueue.Count;
        for (int i = 0; i < count; i++)
        {
            KillableCharacter curr = CombatantQueue.Dequeue();
            if (curr.Stats.Health > 0)
            {
                newQueue.Enqueue(curr);
            }
        }
        CombatantQueue = newQueue;
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
