using Microsoft.AspNetCore.Mvc;

namespace Address_books.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
