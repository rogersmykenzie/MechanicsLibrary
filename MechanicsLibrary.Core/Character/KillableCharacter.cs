namespace MechanicsLibrary.Core.Character;

public class KillableCharacter : Character
{
    private int _health { get; set; }

    public KillableCharacter(int health)
    {
        _health = health;
    }
}