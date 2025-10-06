using Microsoft.AspNetCore.Mvc;
using TI_Net_2025_DemoAPI.API.Mappers;
using TI_Net_2025_DemoAPI.API.Models.Book;
using TI_Net_2025_DemoAPI.BLL.Services.Interfaces;
using TI_Net_2025_DemoAPI.DL.Entities;

namespace TI_Net_2025_DemoAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public ActionResult<List<BookIndexDto>> GetBooks()
        {
            List<BookIndexDto> books = _bookService.GetBooks()
                .Select(b => b.ToBookIndexDto())
                .ToList();

            return Ok(books);
        }

        [HttpGet("{id}")]
        public ActionResult<BookDetailsDto> GetBook([FromRoute] long id)
        {
            BookDetailsDto book = _bookService.GetBook(id).ToBookDetailsDto();

            return Ok(book);
        }

        [HttpPost]
        public ActionResult Add([FromBody] BookFormDto form)
        {
            Book created = _bookService.Add(form.ToBook());

            return Created();
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromRoute] long id, [FromBody] BookFormDto form)
        {
            _bookService.Update(id, form.ToBook());

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] long id)
        {
            _bookService.Delete(id);
            return Accepted();
        }
    }
}
