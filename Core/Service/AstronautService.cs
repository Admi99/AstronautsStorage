using Core.Entity;
using Core.Infrastructure;

namespace Core.Service;

public class AstronautService : IAstronautService
{
    private readonly IAstronautRepository _astronautRepository;

    public AstronautService(IAstronautRepository astronautRepository)
    {
        _astronautRepository = astronautRepository;
    }

    public async Task AddAstronautAsync(Astronaut astronaut)
        => await _astronautRepository.AddAsync(astronaut);

    public async Task DeleteAstronautAsync(int id)
        => await _astronautRepository.DeleteAsync(id);

    public async Task<IEnumerable<Astronaut>> GetAsync()
        => await _astronautRepository.GetAstronautsAsync();

    public async Task<Astronaut?> GetAsync(int id)
        => await _astronautRepository.GetAstronautAsync(id);
}