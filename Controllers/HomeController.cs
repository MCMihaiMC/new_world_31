using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using new_world_31.Models;
using Newtonsoft.Json;

namespace new_world_31.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public string Contact()
        {
            var user = new User {
                Username = "Mihai",
                Fullname = "Muntean Mihai",
                Password = "parola"
            };

            var json = JsonConvert.SerializeObject(user, Formatting.Indented);
            _logger.LogInformation(json);
            return json;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
