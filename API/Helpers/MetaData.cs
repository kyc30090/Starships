namespace API.Helpers
{
    public class MetaData
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public MetaData(int currentPage, int pageSize, int totalPages, int totalCount) 
        {
            this.CurrentPage = currentPage;
            this.PageSize = pageSize;
            this.TotalPages = totalPages;
            this.TotalCount = totalCount;
        }
    }
}