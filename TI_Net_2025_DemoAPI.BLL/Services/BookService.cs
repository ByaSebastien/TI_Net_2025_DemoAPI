using TI_Net_2025_DemoAPI.BLL.Services.Interfaces;
using TI_Net_2025_DemoAPI.DL.Entities;

namespace TI_Net_2025_DemoAPI.BLL.Services
{
    public class BookService : IBookService
    {
        public Book Add(Book book)
        {
            return new Book();
        }

        public void Delete(long id)
        {
        }

        public Book GetBook(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetBooks()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, Book book)
        {
            throw new NotImplementedException();
        }
    }
}
