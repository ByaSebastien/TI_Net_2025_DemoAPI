using TI_Net_2025_DemoAPI.BLL.Services.Interfaces;
using TI_Net_2025_DemoAPI.DL.Entities;

namespace TI_Net_2025_DemoAPI.BLL.Services
{
    public class BookService : IBookService
    {
        public static long NextId = 11;

        public static readonly List<Book> Books = new()
        {
            new Book
            {
                Id = 1,
                Title = "Le Seigneur des Anneaux : La Communauté de l’Anneau",
                Description = "Premier tome de la célèbre trilogie de J.R.R. Tolkien.",
                Release = new DateOnly(1954, 7, 29)
            },
            new Book
            {
                Id = 2,
                Title = "1984",
                Description = "Un roman dystopique de George Orwell sur la surveillance et la liberté.",
                Release = new DateOnly(1949, 6, 8)
            },
            new Book
            {
                Id = 3,
                Title = "Harry Potter à l’école des sorciers",
                Description = "Premier tome de la saga magique de J.K. Rowling.",
                Release = new DateOnly(1997, 6, 26)
            },
            new Book
            {
                Id = 4,
                Title = "Le Petit Prince",
                Description = "Un conte poétique et philosophique d’Antoine de Saint-Exupéry.",
                Release = new DateOnly(1943, 4, 6)
            },
            new Book
            {
                Id = 5,
                Title = "Les Misérables",
                Description = "Chef-d’œuvre de Victor Hugo sur la justice et la rédemption.",
                Release = new DateOnly(1862, 4, 3)
            },
            new Book
            {
                Id = 6,
                Title = "Dune",
                Description = "Roman de science-fiction culte de Frank Herbert.",
                Release = new DateOnly(1965, 8, 1)
            },
            new Book
            {
                Id = 7,
                Title = "L’Alchimiste",
                Description = "Un voyage initiatique écrit par Paulo Coelho.",
                Release = new DateOnly(1988, 4, 1)
            },
            new Book
            {
                Id = 8,
                Title = "Fahrenheit 451",
                Description = "Roman de Ray Bradbury sur la censure et la destruction des livres.",
                Release = new DateOnly(1953, 10, 19)
            },
            new Book
            {
                Id = 9,
                Title = "L’Étranger",
                Description = "Un roman existentiel d’Albert Camus.",
                Release = new DateOnly(1942, 5, 19)
            },
            new Book
            {
                Id = 10,
                Title = "Le Nom du Vent",
                Description = "Premier tome de la Chronique du Tueur de Roi de Patrick Rothfuss.",
                Release = new DateOnly(2007, 3, 27)
            }
        };
        public Book Add(Book book)
        {
            book.Id = NextId++;
            Books.Add(book);
            return book;
        }

        public void Delete(long id)
        {
            Book b = GetBook(id);
            Books.Remove(b);
        }

        public Book GetBook(long id)
        {
            return Books.FirstOrDefault(b => b.Id == id)!;
        }

        public IEnumerable<Book> GetBooks()
        {
            return Books;
        }

        public void Update(long id, Book book)
        {
            Book b = GetBook(id)!;

            b.Title = book.Title;
            b.Description = book.Description;
            b.Release = book.Release;
        }
    }
}
