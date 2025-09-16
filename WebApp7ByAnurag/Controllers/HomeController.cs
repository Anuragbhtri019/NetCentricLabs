using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace WebApp7ByAnurag.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Privacy() => View();

        [Authorize(Roles = "Admin")]
        public IActionResult AdminPage() => View();
    }
}
