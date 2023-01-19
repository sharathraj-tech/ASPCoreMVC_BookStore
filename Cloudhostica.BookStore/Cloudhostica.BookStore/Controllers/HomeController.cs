using Microsoft.AspNetCore.Mvc;

namespace Cloudhostica.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
