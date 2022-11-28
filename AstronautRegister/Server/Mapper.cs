using Core.Entity;

namespace AstronautRegister.Server;

public static class Mapper
{
    public static Shared.Astronaut ToResponse(this Astronaut astronaut)
        => new()
        {
            Id = astronaut.Id,
            Name = astronaut.FirstName,
            Surname = astronaut.LastName,
            DateOfBirth = astronaut.BirthOfDate,
            Superpower = astronaut.SuperPower
        };
    
    public static Astronaut ToEntity(this Shared.Astronaut astronaut)
        => new()
        {
            Id = astronaut.Id,
            FirstName = astronaut.Name,
            LastName = astronaut.Surname,
            BirthOfDate = astronaut.DateOfBirth,
            SuperPower = astronaut.Superpower
        };
}