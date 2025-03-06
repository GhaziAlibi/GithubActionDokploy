using System.Diagnostics;
using GithubActionDokploy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GithubActionDokploy.Controllers
{
    public class HomeController(ILogger<HomeController> logger, IConfiguration configuration) : Controller
    {
        private readonly ILogger<HomeController> _logger = logger;
        private readonly IConfiguration _configuration = configuration;

        public IActionResult Index()
        {
            ViewData["Version"] = _configuration["Settings:Version"];
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
