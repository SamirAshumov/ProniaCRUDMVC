using Microsoft.AspNetCore.Mvc;
using Pronia.Business.Services.Abstracts;
using System.Diagnostics;

namespace ProniaCRADTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFeatureService _featureService;
        public HomeController(IFeatureService featureService)
        {
            _featureService = featureService;
        }
        public IActionResult Index()
        {
            var features = _featureService.GetAllFeatures();
            return View(features);
        }
    }
}
