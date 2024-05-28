namespace Fina.Core.Requests
{
    public abstract class PagedRequest : Request
    {
        public int PageSize { get; set; } = Configuration.DafaultPageSize;
        public int PageNumber { get; set; } = Configuration.DafaultPageNumber;
    }
}
