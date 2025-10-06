using TI_Net_2025_DemoAPI.API.Models.Book;
using TI_Net_2025_DemoAPI.DL.Entities;

namespace TI_Net_2025_DemoAPI.API.Mappers
{
    public static class BookMappers
    {
        public static BookIndexDto ToBookIndexDto(this Book book)
        {
            return new BookIndexDto();
        }

        public static BookDetailsDto ToBookDetailsDto(this Book book)
        {
            return new BookDetailsDto();
        }

        public static Book ToBook(this BookFormDto form)
        {
            return new Book();
        }
    }
}
