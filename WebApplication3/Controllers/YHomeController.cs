using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class YHomeController : Controller
    {
        private readonly ILogger<YHomeController> _logger;

        public YHomeController(ILogger<YHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("/Views/YHome/Index.cshtml");
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
