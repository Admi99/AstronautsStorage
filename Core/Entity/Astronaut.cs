namespace Core.Entity;

public record Astronaut
{
    public Guid Id { get; init; }
    
    public string FirstName { get; init; } = string.Empty;
    
    public string LastName { get; init; } = string.Empty;

    public DateTimeOffset BirthOfDate { get; init; }

    public string SuperPower { get; init; } = string.Empty;
}