using MechanicsLibrary.Core.Abilities;
using MechanicsLibrary.Core.Character;

namespace MechanicsLibrary.Core.AI;

public class BasicAI : IAI
{
    public void Act(AIContext ctx)
    {
        // Selfish - do not buff allies, do not debuff enemies
        // If low health, heal self
        // If not low health, attack the weakest enemy
        Ability? heal = ctx.UpNext.Abilities.Find(e => e.Tags.Contains(Tag.Heal));
        if (heal != null && _isLowHealth(ctx))
        {
            Console.WriteLine("Using " + heal.Name);
            heal.Execute(
                new AbilityContext
                {
                    Targets = new List<KillableCharacter> { ctx.UpNext },
                    User = ctx.UpNext,
                }
            );
            return;
        }
        Ability? attack = ctx.UpNext.Abilities.Find(e => e.Tags.Contains(Tag.Offensive));
        KillableCharacter? target = _decideTarget(ctx);

        if (attack != null && target != null)
        {
            // will not aoe - add support later
            Console.WriteLine("Using " + attack.Name);
            attack.Execute(
                new AbilityContext
                {
                    Targets = new List<KillableCharacter> { target },
                    User = ctx.UpNext,
                }
            );
        }
    }

    // Low Health is at or below 20%
    private bool _isLowHealth(AIContext ctx)
    {
        return ctx.UpNext.Stats.Health / ctx.UpNext.Stats.MaxHealth <= .2;
    }

    private KillableCharacter? _decideTarget(AIContext ctx)
    {
        KillableCharacter? firstNonNull = null;
        for (int row = 0; row < ctx.TheirTeam.GetLength(0); row++)
        {
            firstNonNull = Enumerable
                .Range(0, ctx.TheirTeam.GetLength(1))
                .Select(col => ctx.TheirTeam[row, col])
                .FirstOrDefault(cell => cell != null);

            if (firstNonNull != null)
                break;
        }

        return firstNonNull;
    }
}
