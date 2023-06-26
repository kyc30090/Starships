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
    }
}