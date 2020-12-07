using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        //GET
        public IActionResult Error()
        {
            return View();
        }
    }
}
