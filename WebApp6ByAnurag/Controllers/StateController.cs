using Microsoft.AspNetCore.Mvc;

namespace WebApp6ByAnurag.Controllers
{
    public class StateController : Controller
    {
        // 1. Session Example
        public IActionResult SetSession()
        {
            HttpContext.Session.SetString("UserName", "Anurag");
            return Content("Session value set: UserName = Anurag");
        }

        public IActionResult GetSession()
        {
            var userName = HttpContext.Session.GetString("UserName");
            return Content("Session value retrieved: " + userName);
        }

        // 2. HttpContext Example
        public IActionResult HttpContextExample()
        {
            var ip = HttpContext.Connection.RemoteIpAddress?.ToString();
            return Content("Client IP Address: " + ip);
        }

        // 3. TempData Example
        public IActionResult SetTempData()
        {
            TempData["Message"] = "This is TempData Example";
            return RedirectToAction("GetTempData");
        }

        public IActionResult GetTempData()
        {
            var message = TempData["Message"] as string;
            return Content("TempData Value: " + message);
        }

        // 4. Cookies Example
        public IActionResult SetCookie()
        {
            Response.Cookies.Append("MyCookie", "AnuragCookie", new CookieOptions
            {
                Expires = DateTimeOffset.Now.AddMinutes(5)
            });
            return Content("Cookie Set Successfully");
        }

        public IActionResult GetCookie()
        {
            var cookieValue = Request.Cookies["MyCookie"];
            return Content("Cookie Value: " + cookieValue);
        }

        // 5. Query String Example
        public IActionResult QueryStringExample(string name, int age)
        {
            return Content($"Query String Values => Name: {name}, Age: {age}");
        }

        // 6. Hidden Field Example
        [HttpGet]
        public IActionResult HiddenFieldExample()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HiddenFieldExample(string hiddenValue)
        {
            return Content("Hidden Field Value: " + hiddenValue);
        }
    }
}
