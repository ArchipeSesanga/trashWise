using Microsoft.AspNetCore.Mvc;

namespace trashwise.Controllers;

public class SettingsController : Controller
{
    public IActionResult Settings()
    {
        return View();
    }
}