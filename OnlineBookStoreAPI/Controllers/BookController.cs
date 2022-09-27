using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineBookStoreAPI.Models;
using OnlineBookStoreAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var authors = await _bookRepository.GetAllBookAsync();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById([FromRoute] int id)
        {
            var book = await _bookRepository.GetBookByIdAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost("")]
        public async Task<IActionResult> AddBook([FromBody] BookDTO book)
        {
            try
            {
                int Id = await _bookRepository.AddBookAsync(book);
                book.BookId= Id;
                return CreatedAtAction(nameof(GetBookById), new { id = Id, controller = "book" }, book);

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook([FromRoute] int id, [FromBody] BookDTO bookDTO)
        {
            var result = await _bookRepository.UpdateBookAsync(id, bookDTO);
            if (result > 0)
            {
                bookDTO.BookId= id;
                return Ok(bookDTO);
            }
            return BadRequest();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook([FromRoute] int id)
        {
            var result = await _bookRepository.DeleteBookAsync(id);
            if (result > 0)
            {
                return Ok();
            }
            return BadRequest();
        }

    }
}
