using TI_Net_2025_DemoAPI.DL.Entities;

namespace TI_Net_2025_DemoAPI.BLL.Services.Interfaces
{
    public interface IBookService
    {

        IEnumerable<Book> GetBooks();

        Book GetBook(long id);

        Book Add(Book book);

        void Update(long id, Book book);

        void Delete(long id);
    }
}
