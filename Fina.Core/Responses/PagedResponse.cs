using System.Text.Json.Serialization;

namespace Fina.Core.Responses
{
    public class PagedResponse<TData> : Response<TData>
    {
        [JsonConstructor]
        public PagedResponse(TData data, int totalCount, int currentPage = 1, int pageSize = Configuration.DafaultPageSize) : base(data)
        {
            Data = data;
            TotalCount = totalCount;
            CurrentPage = currentPage;
            PageSize = pageSize;
        }

        public PagedResponse(TData? data, int code = Configuration.DafaultStatusCode, string? message = null) : base(data, code, message)
        {

        }

        public int CurrentPage { get; set; }
        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
        public int PageSize { get; set; } = Configuration.DafaultPageSize;
        public int TotalCount { get; set; }
    }
}
