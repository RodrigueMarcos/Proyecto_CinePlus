using CinePlus_BL.Dtos;
using CinePlus_BL.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus_PL.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpPost]
        public IActionResult AddBook([FromBody] BookDTO bookDto)
        {
            try
            {
                _bookService.SaveBook(bookDto);
                return Ok("Book saved successfully.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while saving the book.");
            }
        }
    }
}
