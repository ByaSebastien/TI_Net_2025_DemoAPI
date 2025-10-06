namespace TI_Net_2025_DemoAPI.API.Models.Book
{
    public class BookFormDto
    {
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public DateOnly Release { get; set; }
    }
}
