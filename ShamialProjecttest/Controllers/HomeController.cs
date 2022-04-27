using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShamialProjecttest.Models;

namespace ShamialProjecttest.Controllers
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

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Avatar()
        {
            return View();
        }

        public IActionResult Avengers()
        {
            return View();
        }

        public IActionResult BTFTM()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Recent()
        {
            return View();
        }

        public IActionResult Reviews()
        {
            return View();
        }

        public IActionResult SWROS()
        {
            return View();
        }

        public IActionResult Titanic()
        {
            return View();
        }

        public IActionResult Upcoming()
        {
            return View();
        }

        public IActionResult WW84()
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
