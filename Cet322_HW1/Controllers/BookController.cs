using Cet322_HW1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cet322_HW1.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Display(string bookName, string author, int pageNumber, DateTime dueDate)
        {
            var book = new Book
            {
                BookName = bookName,
                Author = author,
                PageNumber = pageNumber,
                DueDate = dueDate
            };

            return View(book);
        }
    }
}
