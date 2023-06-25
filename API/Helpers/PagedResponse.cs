using Microsoft.EntityFrameworkCore;

namespace API.Helpers
{
    public class PagedResponse<T>
    {
        public PagedResponse(PagedList<T> results, string url)
        {
            string pageUrl = url + "?page=";
            Count = results.TotalCount;
            Next = results.CurrentPage >= results.TotalPages ? null : pageUrl + (results.CurrentPage + 1);
            Previous = results.CurrentPage <= 1 ? null : pageUrl + (results.CurrentPage - 1);
            Results = results;
        }

        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public PagedList<T> Results { get; set; }

        public static async Task<PagedResponse<T>> CreateAsync(IQueryable<T> source,
            int pageNumber, int pageSize, string url)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
            var results = new PagedList<T>(items, count, pageNumber, pageSize);
            return new PagedResponse<T>(results, url);
        }
    }
}