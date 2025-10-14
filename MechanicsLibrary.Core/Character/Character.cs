namespace MechanicsLibrary.Core.Character;

public class Character
{
    public string Id { get; init; } = Guid.NewGuid().ToString();
    public required string Name { get; init; } = "Unnamed";
}
