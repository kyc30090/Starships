using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    public interface IStarshipRepository
    {
        void Update(Starship starship);
        Task<IEnumerable<Starship>> GetStarshipsAsync();
        Task<Starship> GetStarshipByIdAsync(int id);
        Task<Starship> GetStarshipByNameAsync(string name);
        Task<Starship> GetRandomStarship();
        Task<bool> SaveAllAsync();
    }
}