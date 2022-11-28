namespace Core.Entity;

public record Astronaut
{
    public int Id { get; init; }
    public string FirstName { get; init; } = string.Empty;
    
    public string LastName { get; init; } = string.Empty;

    public DateTimeOffset BirthOfDate { get; init; }

    public string SuperPower { get; init; } = string.Empty;
}