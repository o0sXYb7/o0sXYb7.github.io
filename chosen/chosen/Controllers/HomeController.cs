using chosen.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace chosen.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult empty()
        {
            return View();
        }

        public IActionResult signup()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Aboutus()
        {
            return View();
        }

        public IActionResult Prizepool()
        {
            return View();
        }

        public IActionResult Trading()
        {
            return View();
        }

        public IActionResult Game()
        {
            return View();
        }

        public IActionResult Customerservice()
        {
            return View();
        }

        public IActionResult Classification()
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