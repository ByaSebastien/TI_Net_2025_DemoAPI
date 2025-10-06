using TI_Net_2025_DemoAPI.BLL.Services.Interfaces;
using TI_Net_2025_DemoAPI.DL.Entities;

namespace TI_Net_2025_DemoAPI.BLL.Services
{
    public class BookService : IBookService
    {
        public Book Add(Book book)
        {
            return null;
        }

        public void Delete(long id)
        {
            Console.WriteLine("Deleted!");
        }

        public Book GetBook(long id)
        {
            return new Book();
        }

        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>();
        }

        public void Update(long id, Book book)
        {
            Console.WriteLine("Updated!");
        }
    }
}
