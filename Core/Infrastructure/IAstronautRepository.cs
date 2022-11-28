using Core.Entity;

namespace Core.Infrastructure;

public interface IAstronautRepository
{
    Task AddAsync(Astronaut astronaut);
    Task DeleteAsync(int id);
    Task<Astronaut?> GetAstronautAsync(int id);
    Task<IEnumerable<Astronaut>> GetAstronautsAsync();
}