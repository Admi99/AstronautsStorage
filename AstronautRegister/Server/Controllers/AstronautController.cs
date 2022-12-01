using AstronautRegister.Shared;
using Core.Service;
using Microsoft.AspNetCore.Mvc;

namespace AstronautRegister.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class AstronautController : ControllerBase
{
    private readonly IAstronautService _astronautService;

    public AstronautController(IAstronautService astronautService)
    {
        _astronautService = astronautService;
    }
    
    [HttpPost]
    public async Task<IActionResult> AddAstronaut([FromBody] Astronaut astronaut)
    {
        await _astronautService.AddAstronautAsync(astronaut.ToEntity());
        return Ok();
    }
    
    [HttpDelete("del/{id}")]
    public async Task<IActionResult> DeleteAstronaut([FromRoute] Guid id)
    {
        await _astronautService.DeleteAstronautAsync(id);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var astronauts = await _astronautService.GetAsync();
        var astronautsResponse = astronauts.Select(a => a.ToResponse());
        
        return Ok(astronautsResponse);
    }
    
    [HttpGet("get/{id}")]
    public async Task<IActionResult> Get([FromRoute] Guid id)
    {
        var astronaut = await _astronautService.GetAsync(id);
        return astronaut == null ? NotFound() : Ok(astronaut.ToResponse());
    }
}