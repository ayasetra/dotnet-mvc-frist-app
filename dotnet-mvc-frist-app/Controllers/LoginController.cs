using Microsoft.AspNetCore.Mvc;

namespace MyAdminLTEApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: /Login
        public IActionResult Index()
        {
            return View();
        }

        // POST: /Login
        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            // Contoh validasi sederhana (hardcode)
            if (username == "admin" && password == "123")
            {
                // Simpan session user
                HttpContext.Session.SetString("UserName", username);

                // Redirect ke Dashboard
                return RedirectToAction("Index", "Dashboard");
            }

            // Jika gagal, tampilkan pesan error
            ViewBag.Error = "Username atau password salah!";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
