namespace MechanicsLibrary.Core.Character;

public class Enemy : KillableCharacter
{
    public void Debug()
    {
        Console.WriteLine("Health at " + Stats.Health);
    }
}
