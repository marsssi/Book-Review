using Book_Review.Data.Services;
using Book_Review.Data.ViewModels;
using Microsoft.AspNetCore.Http; 
using Microsoft.AspNetCore.Mvc;

namespace Book_Review.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksService _booksService;

        public BooksController(BooksService booksService)
        {
            _booksService = booksService;
        }


        //Creating #1 API endpoint (HttpPost) to add books 
        [HttpPost("add-book")]
        public IActionResult AddBook([FromBody]BookVM book)
        {
            _booksService.AddBook(book);
            return Ok();
        }


        //Creating #2 API endpoint (HttpGet) to list all books 
        [HttpGet("get-all-books")]
        public IActionResult GetAllBooks()
        {
            var allBooks = _booksService.GetAllBooks();
            return Ok(allBooks);
        }


        //Creating #3 API endpoint (HttpGet) to list a book by Id
        [HttpGet("get-book-by-Id/{id}")]
        public IActionResult GetBookById(int id)
        {
             var book = _booksService.GetBookById(id);
            return Ok(book);
        }


        //Creating #4 API endpoint (HttpPut) to update an existing book by Id
        [HttpPut("update-book-by-Id/{id}")]
        public IActionResult UpdateBookById(int id, [FromBody]BookVM book)
        {
            var updatedBook = _booksService.UpdateBookById(id, book);
            return Ok(updatedBook);
        }


        //Creating #5 API endpoint (HttpDelete) to delete a book by Id
        [HttpDelete("delete-book-by-Id/{id}")]
        public IActionResult DeleteBookById(int id)
        {
            _booksService.DeleteBookById(id);
            return Ok();
        }
    }
}
