using Core.Entity;
using Infrastructure.DatabaseObjects;

namespace Infrastructure.Repository;

public static class AstronautMapper
{
    public static Astronaut MapToAstronaut(this AstronautDo entity)
        => new()
        {
            Id = entity.Id,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            BirthOfDate = entity.DateOfBirth,
            SuperPower = entity.SuperPower
        };
    
    public static AstronautDo MapToAstronautDo(this Astronaut entity)
        => new()
        {
            Id = entity.Id,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            DateOfBirth = entity.BirthOfDate,
            SuperPower = entity.SuperPower
        };
}