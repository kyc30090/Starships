using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StarshipRepository : IStarshipRepository
    {
        private readonly DataContext _context;
        public StarshipRepository(DataContext context)
        {
            _context = context;
            
        }

        public async Task<Starship> GetRandomStarship()
        {
            List<int> starshipIds = await _context.Starships.Select(x => x.Id).ToListAsync();
            int random = new Random().Next(starshipIds.Count);
            int starshipId = starshipIds.ElementAt(random);
            return await GetStarshipByIdAsync(starshipId);
        }

        public async Task<Starship> GetStarshipByIdAsync(int id)
        {
            return await _context.Starships.FindAsync(id);
        }

        public async Task<Starship> GetStarshipByNameAsync(string name)
        {
            return await _context.Starships.SingleOrDefaultAsync(x => x.Name == name);
        }

        public async Task<IEnumerable<Starship>> GetStarshipsAsync()
        {
            return await _context.Starships.ToListAsync();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update(Starship starship)
        {
            _context.Entry(starship).State = EntityState.Modified;
        }
    }
}