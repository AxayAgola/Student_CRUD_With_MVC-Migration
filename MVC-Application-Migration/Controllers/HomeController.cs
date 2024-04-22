using Microsoft.AspNetCore.Mvc;
using MVC_Application_Migration.Data;
using MVC_Application_Migration.Models;
using System.Diagnostics;

namespace MVC_Application_Migration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        protected StudentDBContext _db;

        public HomeController(ILogger<HomeController> logger, StudentDBContext db)
        {
            _logger = logger;
            _db = db;
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