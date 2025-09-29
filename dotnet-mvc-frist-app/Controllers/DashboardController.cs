using Microsoft.AspNetCore.Mvc;

namespace MyAdminLTEApp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            // Cek apakah sudah login
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("UserName")))
            {
                return RedirectToAction("Index", "Login");
            }

            ViewBag.User = HttpContext.Session.GetString("UserName");
            return View();
        }
    }
}
