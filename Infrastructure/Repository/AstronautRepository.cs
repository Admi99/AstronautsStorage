using Core.Entity;
using Core.Infrastructure;
using Infrastructure.DatabaseObjects;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class AstronautRepository : IAstronautRepository
{
    private readonly AstronautRegisterDbContext _dbContext;

    public AstronautRepository(AstronautRegisterDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddAsync(Astronaut astronaut)
    {
        var astronautsDo = astronaut.MapToAstronautDo();
        await _dbContext.Astronauts.AddAsync(astronautsDo);
        
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var astronautDo = new AstronautDo { Id = id };
        _dbContext.Astronauts.Attach(astronautDo);
        _dbContext.Astronauts.Remove(astronautDo);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<Astronaut?> GetAstronautAsync(int id)
    {
        var result = await _dbContext.Astronauts.FirstOrDefaultAsync(a => a.Id == id);
        return result?.MapToAstronaut();
    }

    public async Task<IEnumerable<Astronaut>> GetAstronautsAsync()
    {
        var result = await _dbContext.Astronauts.ToListAsync();
        return result.Select(astronaut => astronaut.MapToAstronaut());
    }
}