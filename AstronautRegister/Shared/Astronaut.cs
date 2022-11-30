using System.ComponentModel.DataAnnotations;

namespace AstronautRegister.Shared;

public record Astronaut
{
    public int Id { get; init; }
    
    [Required]
    [StringLength(49, ErrorMessage = "First name is too long")]
    public string Name { get; set; } = string.Empty;
    
    [Required]
    [StringLength(49, ErrorMessage = "Last name is too long")]
    public string Surname { get; set; } = string.Empty;

    [Required]
    public DateTimeOffset DateOfBirth { get; set; }

    [Required]
    [StringLength(49, ErrorMessage = "Superpower is too long")]
    public string Superpower { get; set; } = string.Empty;
}