using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Helpers;

namespace API.Interfaces
{
    public interface IStarshipRepository
    {
        void Update(Starship starship);
        Task<PagedResponse<Starship>> GetStarshipsAsync(PageParams pageParams);
        Task<Starship> GetStarshipByIdAsync(int id);
        Task<Starship> GetStarshipByNameAsync(string name);
        Task<Starship> GetRandomStarship();
        Task<bool> SaveAllAsync();
    }
}