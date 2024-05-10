using Microsoft.AspNetCore.Mvc;

namespace ProniaCRADTask.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
