namespace TI_Net_2025_DemoAPI.API.Models.Book
{
    public class BookIndexDto
    {
        public long Id { get; set; }
        public string Title { get; set; } = null!;
        public DateOnly Release {  get; set; }
    }
}
