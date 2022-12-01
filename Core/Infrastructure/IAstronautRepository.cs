using Core.Entity;

namespace Core.Infrastructure;

public interface IAstronautRepository
{
    Task AddAsync(Astronaut astronaut);
    Task DeleteAsync(Guid id);
    Task<Astronaut?> GetAstronautAsync(Guid id);
    Task<IEnumerable<Astronaut>> GetAstronautsAsync();
}