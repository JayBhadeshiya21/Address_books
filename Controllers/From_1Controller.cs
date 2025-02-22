using Microsoft.AspNetCore.Mvc;

namespace Address_books.Controllers
{
    public class From_1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult submit(IFormCollection fc)
        {
            ViewBag.name = fc["name"];
            ViewBag.email = fc["email"];
            ViewBag.phone = fc["phone"];
            ViewBag.address = fc["address"];
            ViewBag.gender = fc["gender"];
            ViewBag.country = fc["country"];
            ViewBag.hobbie = fc["hobbie"];
            return View("Index");
        }


    }
}
