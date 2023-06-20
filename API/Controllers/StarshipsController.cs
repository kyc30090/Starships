using API.Data;
using API.Entities;
using API.Helpers;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StarshipsController : ControllerBase
{
    private readonly IStarshipRepository _starshipRepository;

    public StarshipsController(IStarshipRepository starshipRepository)
    {
        _starshipRepository = starshipRepository;
    }
    [HttpGet("list")]
    public async Task<ActionResult<PagedResponse<Starship>>> GetStarShips([FromQuery] PageParams pageParams)
    {
        return Ok(await _starshipRepository.GetStarshipsAsync(pageParams));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Starship>> GetStarship(int id)
    {
        return await _starshipRepository.GetStarshipByIdAsync(id);
    }

    [HttpGet("random")]
    public async Task<ActionResult<Starship>> GetRandomShip()
    {
        return Ok(await _starshipRepository.GetRandomStarship());
    }
}