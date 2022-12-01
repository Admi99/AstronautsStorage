namespace Infrastructure.DatabaseObjects;

public class AstronautDo
{
    public int Id { get; init; }
    
    public string FirstName { get; init; } = string.Empty;

    public string LastName { get; init; } = string.Empty;

    public DateTimeOffset DateOfBirth { get; init; }

    public string SuperPower { get; init; } = string.Empty;
}