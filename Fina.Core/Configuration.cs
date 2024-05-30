namespace Fina.Core
{
    public static class Configuration
    {
        public const int DafaultStatusCode = 200;
        public const int DafaultPageNumber = 1;
        public const int DafaultPageSize = 25;

        public static string BackendUrl { get; set; } = string.Empty;
        public static string FrontEndUrl { get; set; } = string.Empty;
    }
}
