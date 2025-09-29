using Microsoft.AspNetCore.Mvc;

public class ProfileController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Profile";
        return View();
    }
}
