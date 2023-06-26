using System.Text.Json;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Helpers;
using AutoMapper;
using AutoMapper.QueryableExtensions;
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
    public async Task<ActionResult<PagedResponse<StarshipDto>>> GetStarShips([FromQuery] ShipsParams shipsParams)
    {
        var query = _context.Starships.AsNoTracking()
                        .Include(s => s.Films)
                        .SortBy(shipsParams.Orderby)
                        .Search(shipsParams.SearchTerm)
                        .Filter(shipsParams.ShipClasses);
        var starships = await CreateDtosAsync(query, shipsParams.PageNumber, shipsParams.PageSize, "https://swapi.dev/api/starships/list");

        var results = starships.Results;
        MetaData metaData = new MetaData(results.CurrentPage, results.PageSize, results.TotalPages, results.TotalCount);
        Response.AddPaginationHeader(metaData);
        
        return Ok(starships);
    }

    [HttpGet("{id}", Name = "GetStarship")]
    public async Task<ActionResult<StarshipDto>> GetStarshipAsync(int id)
    {
        var starship = await GetStarshipDtoByIdAsync(id);
        if (starship == null) return NotFound();
        return starship;
    }

    [HttpGet("random")]
    public async Task<ActionResult<StarshipDto>> GetRandomShip()
    {
        List<int> starshipIds = await _context.Starships.Select(x => x.Id).ToListAsync();
        int random = new Random().Next(starshipIds.Count);
        int starshipId = starshipIds.ElementAt(random);

        var starship = await GetStarshipDtoByIdAsync(starshipId);
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

        if (!string.IsNullOrWhiteSpace(starship.Image))
            await _imageService.DeleteImage(starship.Image.Split('/').Last(), StarshipsConstants.Storage_Container);

        _context.Starships.Remove(starship);
        var result = await _context.SaveChangesAsync() > 0;
        if (result) return Ok();

        return BadRequest("Failed to delete starship");
    }

    [HttpGet("filters")]
    public async Task<ActionResult> GetFilters()
    {
        var shipClasses = await _context.Starships
                                    .Where(s => !string.IsNullOrWhiteSpace(s.StarshipClass))
                                    .Select(s => s.StarshipClass.ToLower())
                                    .Distinct()
                                    .OrderBy(n => n)
                                    .ToListAsync();

        return Ok(new { shipClasses });
    }

    [HttpPost("addFilms")]
    public async Task<ActionResult> AddFilmsToShip(FilmShipListDto filmShipsDto)
    {
        Starship starship = await GetStarshipByIdAsync(filmShipsDto.StarshipId);
        if (starship == null) return NotFound();

        List<Film> films =  await _context.Films.Where(f => filmShipsDto.FilmIds.Any(id => f.Id == id)).ToListAsync();
        // Remove all films if dto contains empty film ids
        if (!films.Any() && filmShipsDto.FilmIds.Any()) return NotFound();

        starship.Films = films;
        var result = await _context.SaveChangesAsync() > 0;
        if (result) return Ok();

        return BadRequest();
    }

    [HttpPost("addPilots")]
    public async Task<ActionResult> AddPilotsToShip(PersonShipListDto personShipDto)
    {
        Starship starship = await GetStarshipByIdAsync(personShipDto.StarshipId);
        if (starship == null) return NotFound();

        List<Person> people =  await _context.People.Where(p => personShipDto.PersonIds.Any(id => p.Id == id)).ToListAsync();
        // Remove all films if dto contains empty film ids
        if (!people.Any() && personShipDto.PersonIds.Any()) return NotFound();

        starship.Pilots = people;
        var result = await _context.SaveChangesAsync() > 0;
        if (result) return Ok();

        return BadRequest();
    }

    private async Task<Starship> GetStarshipByIdAsync(int id)
    {
        return await _context.Starships
                                    .Include(s => s.Films)
                                    .Include(s => s.Pilots)
                                    .FirstOrDefaultAsync(s => s.Id == id);
    }

    private async Task<StarshipDto> GetStarshipDtoByIdAsync(int id)
    {
        return await _context.Starships
                                    .Include(s => s.Films)
                                    .Include(s => s.Pilots)
                                    .ProjectTo<StarshipDto>(_mapper.ConfigurationProvider)
                                    .FirstOrDefaultAsync(s => s.Id == id);
    }

    private async Task<PagedResponse<StarshipDto>> CreateDtosAsync(IQueryable<Starship> source,
            int pageNumber, int pageSize, string url)
        {
            var count = await source.CountAsync();
            var itemsDto = await source
                        .ProjectTo<StarshipDto>(_mapper.ConfigurationProvider)
                        .Skip((pageNumber - 1) * pageSize)
                        .Take(pageSize)
                        .ToListAsync();
            var results = new PagedList<StarshipDto>(itemsDto, count, pageNumber, pageSize);
            return new PagedResponse<StarshipDto>(results, url);
        }
}