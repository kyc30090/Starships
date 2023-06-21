using API.Data;
using API.DTOs;
using API.Entities;
using API.Helpers;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StarshipsController : ControllerBase
{
    private readonly DataContext _context;

    private readonly IMapper _mapper;

    public StarshipsController(IMapper mapper, DataContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    [HttpGet("list")]
    public async Task<ActionResult<PagedResponse<Starship>>> GetStarShips([FromQuery] PageParams pageParams)
    {
        var query = _context.Starships.AsNoTracking();
        return Ok(await PagedResponse<Starship>.CreateAsync(query, pageParams.PageNumber, pageParams.PageSize, "https://swapi.dev/api/starships/list"));
    }

    [HttpGet("{id}", Name = "GetStarship")]
    public async Task<ActionResult<Starship>> GetStarshipAsync(int id)
    {
        var starship = await _context.Starships.FindAsync(id);
        if (starship == null) return NotFound();
        return starship;
    }

    [HttpGet("random")]
    public async Task<ActionResult<Starship>> GetRandomShip()
    {
        List<int> starshipIds = await _context.Starships.Select(x => x.Id).ToListAsync();
        int random = new Random().Next(starshipIds.Count);
        int starshipId = starshipIds.ElementAt(random);
        
        var starship = await _context.Starships.FindAsync(starshipId);
        if (starship == null) return NotFound();
        return starship;
    }

    [HttpPost]
    public async Task<ActionResult<Starship>> CreateStarship(StarshipCreateDto starshipCreateDto)
    {
        var starship = _mapper.Map<Starship>(starshipCreateDto);
        _context.Starships.Add(starship);
        var result = await _context.SaveChangesAsync() > 0;

        if (result) return CreatedAtRoute("GetStarship", new { Id = starship.Id }, starship);

        return BadRequest("Failed to create starship");
    }

    [HttpPut]
    public async Task<ActionResult> UpdateStarship(StarshipUpdateDto starshipDto)
    {
        Starship starship = await _context.Starships.FindAsync(starshipDto.Id);

        if (starship == null) return NotFound();
        _mapper.Map(starshipDto, starship);

        var result = await _context.SaveChangesAsync() > 0;
        if (result) return NoContent();

        return BadRequest("Failed to update starship");
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteStarship(int id)
    {
        Starship starship = await _context.Starships.FindAsync(id);

        if (starship == null) return NotFound();

        _context.Starships.Remove(starship);
        var result = await _context.SaveChangesAsync() > 0;
        if (result) return Ok();

        return BadRequest("Failed to delete starship");
    }
}