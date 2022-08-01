using Microsoft.AspNetCore.Mvc;

namespace CartPage.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
