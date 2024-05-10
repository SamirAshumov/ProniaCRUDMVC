using Microsoft.AspNetCore.Mvc;

namespace ProniaCRADTask.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
