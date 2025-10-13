namespace MechanicsLibrary.Core.Character;

public class Hero : KillableCharacter
{
    private int _xp;
    public Hero(int health, int xp) : base(health)
    {
        _xp = xp;
    }
    
    public void Debug()
    {
        Console.WriteLine(_xp);
    }
}