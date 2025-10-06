using TI_Net_2025_DemoAPI.API.Models.Book;
using TI_Net_2025_DemoAPI.DL.Entities;

namespace TI_Net_2025_DemoAPI.API.Mappers
{
    public static class BookMappers
    {
        public static BookIndexDto ToBookIndexDto(this Book book)
        {
            return new BookIndexDto()
            {
                Id = book.Id,
                Title = book.Title,
                Release = book.Release,
            };
        }

        public static BookDetailsDto ToBookDetailsDto(this Book book)
        {
            return new BookDetailsDto()
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
                Release = book.Release,
            };
        }

        public static Book ToBook(this BookFormDto form)
        {
            return new Book()
            {
                Title = form.Title,
                Description = form.Description,
                Release = form.Release,
            };
        }
    }
}
