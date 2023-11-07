using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestWeb.Data;

namespace TestWeb.Controllers
{
    public class BookController : Controller
    {
        private readonly DataContext context;

        public BookController(DataContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Detail(string name)
        {
            var book = await context.Books.FirstOrDefaultAsync(book => book.name == name);
            return View(book);
        }
    }
}
