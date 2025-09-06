using Microsoft.AspNetCore.Mvc;
using WebApp2ByAnurag.Services;

namespace WebApp2ByAnurag.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEnumerable<IGreetingService> _greetingServices;

        public HomeController(IEnumerable<IGreetingService> greetingServices)
        {
            _greetingServices = greetingServices;
        }

        public IActionResult Index()
        {
            var messages = _greetingServices.Select(s => s.GetGreeting());
            ViewData["Message"] = string.Join("<br>", messages);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
