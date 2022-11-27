namespace AstronautRegister.Shared;

public record Astronaut
{
    public string Name { get; set; } = string.Empty;
    
    public string Surname { get; set; } = string.Empty;

    public DateTimeOffset DateOfBirth { get; set; }

    public string Superpower { get; set; } = string.Empty;
}