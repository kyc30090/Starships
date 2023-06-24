using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using SQLitePCL;

namespace API.Helpers
{
    public static class ShipExtensions
    {
        public static IQueryable<Starship> SortBy(this IQueryable<Starship> query, string orderBy)
        {
            query = orderBy switch
            {
                "name" => query.OrderBy(p => p.Name),
                "nameDesc" => query.OrderByDescending(p => p.Name),
                _ => query.OrderBy(p => p.Id)
            };
            return query;
        }

        public static IQueryable<Starship> Search(this IQueryable<Starship> query, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm)) return query;
            var lowerCaseSearchTerm = searchTerm.Trim().ToLower();
            return query.Where(p => p.Name.ToLower().Contains(lowerCaseSearchTerm));
        }

        public static IQueryable<Starship> Filter(this IQueryable<Starship> query, string shipClasses)
        {
            if (string.IsNullOrWhiteSpace(shipClasses)) return query;

            var shipList = new List<string>();

            shipList.AddRange(shipClasses.ToLower().Split(",").ToList());

            query = query.Where(p => shipList.Count == 0 || shipList.Contains(p.StarshipClass.ToLower()));
            return query;
        }


    }
}