using LibraryList.Data; // Adjust based on the actual namespace where Book and LandbDbContextClass are defined
using LibraryList.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LibraryList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LandBController : ControllerBase
    {
        private readonly LandbDbContextClass _context;

        public LandBController(LandbDbContextClass context)
        {
            _context = context;
        }

        // GET: api/books
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            var books = _context.Books.ToList();
            return Ok(books);
        }
    }
}
