using Microsoft.AspNetCore.Mvc;

namespace Address_books.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
