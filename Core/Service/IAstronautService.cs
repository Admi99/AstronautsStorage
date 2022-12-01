using Core.Entity;

namespace Core.Service;

public interface IAstronautService
{
    public Task AddAstronautAsync(Astronaut astronaut);
    public Task DeleteAstronautAsync(Guid id);
    public Task<IEnumerable<Astronaut>> GetAsync();
    public Task<Astronaut?> GetAsync(Guid id);
}