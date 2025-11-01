using MechanicsLibrary.Core.Abilities;

namespace MechanicsLibrary.Core.Status;

/*
    Burn has a 20% chance to extinguish itself - but is guaranteed for at least one turn
    Burn does flat damage calculated on application.
*/
public class Burn : IStatus
{
    public required StatusContext Ctx { get; init; }
    int turns = 0;

    public void OnTurnStart()
    {
        if (turns > 1)
        {
            if (_checkIfExtinguished(Ctx))
            {
                return;
            }
        }

        int burnDmg = Ctx.Magnitude; // Update calculation so that it is reduced by magic resist later
        Ctx.Reciever.Stats.Health -= burnDmg;
        turns++;
    }

    private bool _checkIfExtinguished(StatusContext ctx)
    {
        // 20% chance to extinguish
        if (new Random().Next(0, 100) < 20)
        {
            ctx.Reciever.ActiveModifiers.Remove(this);
            return true;
        }
        return false;
    }
}
