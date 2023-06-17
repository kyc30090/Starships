using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StarshipsController : ControllerBase
{
    private readonly DataContext _context;

    public StarshipsController(DataContext context)
    {
        _context = context;
    }
    [HttpGet]
    public async Task<IEnumerable<Starship>> GetAllShips()
    {
        var starships = await _context.Starships.ToListAsync();
        return starships;
    }

    [HttpGet("id")]
    public async Task<Starship> GetStarship(int id)
    {
        return await _context.Starships.FindAsync(id);
    }
}