using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LibraryList.Models.Entities;
using LibraryList.Data;

namespace LibraryList.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly LandbDbContextClass _context;
        private readonly JsonSerializerOptions _jsonOptions;

        public BooksController(LandbDbContextClass context)
        {
            _context = context;

            // Configure JsonSerializerOptions to preserve references
            _jsonOptions = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve,
                WriteIndented = true // Optional: for pretty-printing JSON output
            };
        }

        // GET: api/books
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            var books = _context.Books
                .Include(b => b.Author) // Ensure Author is included
                .ToList(); // Execute the query synchronously and retrieve all books

            return Ok(JsonSerializer.Serialize(books, _jsonOptions));
        }
        

    }
}
