using System.Text.Json;
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
    private readonly IImageService _imageService;
    private readonly IMapper _mapper;

    public StarshipsController(IMapper mapper, DataContext context, IImageService imageService)
    {
        _mapper = mapper;
        _context = context;
        _imageService = imageService;
    }

    [HttpGet("list")]
    public async Task<ActionResult<PagedResponse<Starship>>> GetStarShips([FromQuery] ShipsParams shipsParams)
    {
        var query = _context.Starships.AsNoTracking()
                        .SortBy(shipsParams.Orderby)
                        .Search(shipsParams.SearchTerm)
                        .Filter(shipsParams.ShipClasses);
        var starships = await PagedResponse<Starship>.CreateAsync(query, shipsParams.PageNumber, shipsParams.PageSize, "https://swapi.dev/api/starships/list");

        var results = starships.Results;
        MetaData metaData = new MetaData(results.CurrentPage, results.PageSize, results.TotalPages, results.TotalCount);
        Response.AddPaginationHeader(metaData);
        return Ok(starships);
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
    public async Task<ActionResult<Starship>> CreateStarship([FromForm] StarshipCreateDto starshipCreateDto)
    {
        var starship = _mapper.Map<Starship>(starshipCreateDto);
        starship.Created = DateTime.UtcNow;

        if (starshipCreateDto.File != null && starshipCreateDto.File.Length > 0)
        {
            string fileName = $"{Guid.NewGuid()}{Path.GetExtension(starshipCreateDto.File.FileName)}";
            string image = await _imageService.CreateImage(fileName, StarshipsConstants.Storage_Container, starshipCreateDto.File);
            starship.Image = image;
        }

        _context.Starships.Add(starship);
        var result = await _context.SaveChangesAsync() > 0;

        if (result) return CreatedAtRoute("GetStarship", new { Id = starship.Id }, starship);

        return BadRequest("Failed to create starship");
    }

    [HttpPut]
    public async Task<ActionResult<Starship>> UpdateStarship([FromForm] StarshipUpdateDto starshipDto)
    {
        Starship starship = await _context.Starships.FindAsync(starshipDto.Id);

        if (starship == null) return NotFound();

        _mapper.Map(starshipDto, starship);
        starship.Edited = DateTime.UtcNow;

        if (starshipDto.File != null && starshipDto.File.Length > 0)
        {
            string fileName = $"{Guid.NewGuid()}{Path.GetExtension(starshipDto.File.FileName)}";
            string image = await _imageService.CreateImage(fileName, StarshipsConstants.Storage_Container, starshipDto.File);

            string existingImage = starship.Image;
            if (!string.IsNullOrEmpty(existingImage))
            {
                await _imageService.DeleteImage(existingImage.Split('/').Last(), StarshipsConstants.Storage_Container);

            }

            starship.Image = image;
        }

        var result = await _context.SaveChangesAsync() > 0;
        if (result) return Ok(starship);

        return BadRequest("Failed to update starship");
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteStarship(int id)
    {
        Starship starship = await _context.Starships.FindAsync(id);

        if (starship == null) return NotFound();

        await _imageService.DeleteImage(starship.Image.Split('/').Last(), StarshipsConstants.Storage_Container);
        _context.Starships.Remove(starship);
        var result = await _context.SaveChangesAsync() > 0;
        if (result) return Ok();

        return BadRequest("Failed to delete starship");
    }

    [HttpGet("filters")]
    public async Task<IActionResult> GetFilters()
    {
        var shipClasses = await _context.Starships
                                    .Where(s => !string.IsNullOrWhiteSpace(s.StarshipClass))
                                    .Select(s => s.StarshipClass.ToLower())
                                    .Distinct()
                                    .OrderBy(n => n)
                                    .ToListAsync();

        return Ok(new { shipClasses });
    }
}