using k213375_cloud.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace k213375_cloud.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Action for Introduction Page
        public IActionResult Introduction()
        {
            var model = new IntroductionModel();
            return View(model);
        }

        // Action for Cloud Models Page
        public IActionResult Models()
        {
            var model = new CloudModelsModel();
            return View(model);
        }

        // Action for Evolution Page
        public IActionResult Evolution()
        {
            var model = new EvolutionModel();
            return View(model);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
