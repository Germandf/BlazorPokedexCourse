namespace BlazorPokedexCourse.Models
{
    public class PaginationParameters
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 18;
        public int Offset => (PageNumber - 1) * PageSize;
    }
}
