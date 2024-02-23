using Azure.KeyVault.WebClient.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Azure.KeyVault.WebClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration ;


        public HomeController(ILogger<HomeController> logger,IConfiguration configuration)
        {
            _logger = logger;
            _configuration=configuration;
        }

        public IActionResult Index()
        {
            ViewData["keyvaultvalue"] = _configuration["TestSecret"];
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
