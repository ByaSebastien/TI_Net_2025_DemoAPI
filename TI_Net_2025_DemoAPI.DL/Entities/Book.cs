namespace TI_Net_2025_DemoAPI.DL.Entities
{
    public class Book
    {
        public long Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public DateOnly Release {  get; set; }
    }
}
